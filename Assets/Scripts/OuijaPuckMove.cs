using UnityEngine;
using System.Collections;

public class OuijaPuckMove : MonoBehaviour
{
  public float moveSpeed = 0.05f;
  public float maxRotation = 30.0f;
  public float maxMoveX = 20.0f;
  public float maxMoveY = 13.0f;

	void Update ()
  {
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");
	  Vector3 moveDir = new Vector3(x, 0.0f, z).normalized;

    transform.Translate(moveDir * moveSpeed * Time.deltaTime);

    float rotAngle = transform.localPosition.x / maxMoveX * maxRotation;
    transform.localRotation = Quaternion.Euler(0.0f, rotAngle, 0.0f);
	}
}
