using UnityEngine;
using System.Collections;

public class WorldInteraction : MonoBehaviour
{
  public Camera cam;
  public bool useCursor = false;

  private PickableObject hotObject = null;
  
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
      hotObject.Interact();
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

}
