using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour
{
  private Rigidbody rb;
  public float force = 1.0f;

	void Start ()
  {
	  rb = gameObject.GetComponent<Rigidbody>();
  }
	
	void FixedUpdate ()
  {
    rb.AddForce(Vector3.forward * force);
	}
}
