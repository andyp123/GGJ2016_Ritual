using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour
{
  public Camera cam;
  public bool useCursor = false;

  private GameObject hotObject = null;
  private GameObject activeObject = null;
  

  void Start()
  {
    if (cam == null)
    {
      Debug.LogError("Camera not set");
      Destroy(this);
    }
  }
  

  void Update()
  {
    GameObject targettedObject = FindTargettedObject();
    PickableObject[] pickableObjects;

    // set hot object
    if (hotObject != null && hotObject != targettedObject)
    {
      pickableObjects = hotObject.GetComponents<PickableObject>();
      foreach (PickableObject po in pickableObjects)
        po.FocusLost();
      hotObject = null;
    }

    if (hotObject == null && targettedObject != null)
    {
      hotObject = targettedObject;
      pickableObjects = hotObject.GetComponents<PickableObject>();
      foreach (PickableObject po in pickableObjects)
        po.FocusGained();
    }

    // interaction
    if (hotObject && Input.GetButtonDown("Fire1"))
    {
      activeObject = hotObject;
      pickableObjects = activeObject.GetComponents<PickableObject>();
      foreach (PickableObject po in pickableObjects)
        po.Activate();
    }
    if (activeObject && Input.GetButtonUp("Fire1"))
    {      
      pickableObjects = activeObject.GetComponents<PickableObject>();
      foreach (PickableObject po in pickableObjects)
        po.Deactivate();
      activeObject = null;
    }
  }


  GameObject FindTargettedObject()
  {
    RaycastHit[] hits;
    Ray ray;

    if (!useCursor)
    {
      ray = new Ray(cam.transform.position, cam.transform.forward);
    }
    else
    {
      ray = cam.ScreenPointToRay(Input.mousePosition);
    }

    int layerMask = 1 << LayerMask.NameToLayer("PickableObjects");
    hits = Physics.RaycastAll(ray.origin, ray.direction, Mathf.Infinity, layerMask);

    // NOTE: doesn't bother to check proximity
    foreach (RaycastHit hit in hits)
    {
      PickableObject pickable = hit.transform.gameObject.GetComponent<PickableObject>();
      if (pickable != null)
      {
        return hit.transform.gameObject;
      }
    }

    return null;
  }


  public bool GetLookAtPosition(int layerMask, out Vector3 lookAtPosition)
  {
    RaycastHit[] hits;
    Ray ray;

    if (!useCursor)
    {
      ray = new Ray(cam.transform.position, cam.transform.forward);
    }
    else
    {
      ray = cam.ScreenPointToRay(Input.mousePosition);
    }


    hits = Physics.RaycastAll(ray.origin, ray.direction, Mathf.Infinity, layerMask);

    if (hits.Length == 0)
    {
      lookAtPosition = Vector3.zero;
      return false;
    }

    RaycastHit nearestHit = hits[0];
    float nearestDistance = 99999999.0f;
    
    foreach (RaycastHit hit in hits)
    {
      float distance = (cam.transform.position - hit.point).magnitude;
      if (distance < nearestDistance)
      {
        nearestHit = hit;
        nearestDistance = distance;
      }
    }

    lookAtPosition = nearestHit.point;
    return true;
  }
}
