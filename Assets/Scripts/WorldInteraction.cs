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

    if (hotObject == null && targettedObject != null)
      Debug.Log("new hot object!");

    hotObject = targettedObject;

    // if hot object changes, or is lost, release active object
    if (activeObject != null && activeObject != hotObject)
    {
      //activeObject.Release();
      activeObject = null;
    }

    if (hotObject && Input.GetButtonDown("Fire1"))
    {
      //hotObject.Press();
      activeObject = hotObject;
      Debug.Log("active object!");
    }
    if (activeObject && Input.GetButtonUp("Fire1"))
    {
      //activeObject.Release();
      activeObject = null;
    }

    if (hotObject)
    {
      Debug.DrawLine (cam.transform.position, hotObject.transform.position, Color.yellow);
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
