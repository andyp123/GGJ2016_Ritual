using UnityEngine;
using System.Collections;

public class OuijaPuckMove : MonoBehaviour
{
  public float moveSpeed = 0.05f;

	void Update ()
  {
    float x = Input.GetAxis("Horizontal");
    float y = -Input.GetAxis("Vertical");
	  Vector3 moveDir = new Vector3(x, y, 0.0f).normalized;

    transform.Translate(moveDir * moveSpeed * Time.deltaTime);
	}
}
