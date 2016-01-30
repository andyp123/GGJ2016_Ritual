using UnityEngine;
using System.Collections;

public class OuijaLocator : MonoBehaviour
{

  public GameObject ouijaPuck;
  public float distanceThreshold = 0.02f;
  public float puckRestThreshold = 0.75f;
  public float puckWobbleThreshold = 0.001f;

  private Transform nearestLocator;
  private Transform previousLocator;
  private Vector3 puckLastPos;
  private float puckRestTime = 0.0f;

	void Start ()
  {
    puckLastPos = ouijaPuck.transform.position;

    // foreach (Transform child in transform)
    // {
    //   Debug.Log ( child.name );
    // }
	}
	
	void Update ()
  {
    float wobbleDistance = (ouijaPuck.transform.position - puckLastPos).magnitude;
    puckRestTime = (wobbleDistance <= puckWobbleThreshold) ? puckRestTime += Time.deltaTime : 0.0f;

    if (puckRestTime >= puckRestThreshold)
    {
      UpdateNearestLocator();
      if (nearestLocator != null && nearestLocator != previousLocator)
      {
        Debug.Log(nearestLocator.name);
      }
    }

    puckLastPos = ouijaPuck.transform.position;
	}

  void UpdateNearestLocator ()
  {
    Transform currentNearest = transform;
    Vector3 puckPos = ouijaPuck.transform.position;
    float nearestDistance = 9999999.0f;

    foreach (Transform child in transform)
    {
      float distance = (child.position - puckPos).magnitude;
      if (distance < nearestDistance)
      {
        nearestDistance = distance;
        currentNearest = child;
      }
    } 

    if (nearestDistance < distanceThreshold)
    {
      previousLocator = nearestLocator;
      nearestLocator = currentNearest;
    }
    else
    {
      nearestLocator = null;
    } 
  }
}
