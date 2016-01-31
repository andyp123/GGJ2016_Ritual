using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour
{
  public Camera cam;
  public bool useCursor = false;

  private PickableObject hotObject = null;
  private PickableObject activeObject = null;
  
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
    PickableObject targettedObject = FindTargettedObject();

    // set hot object
    if (hotObject != null && hotObject != targettedObject)
    {
      hotObject.FocusLost();
      hotObject = null;
    }

    if (hotObject == null && targettedObject != null)
    {
      hotObject = targettedObject;
      hotObject.FocusGained();
    }

    // interaction
    if (hotObject && Input.GetButtonDown("Fire1"))
    {
      activeObject = hotObject;
      activeObject.Activate();
    }
    if (activeObject && Input.GetButtonUp("Fire1"))
    {
      activeObject.Deactivate();
      activeObject = null;
    }
  }

  PickableObject FindTargettedObject()
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
        return pickable;
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
