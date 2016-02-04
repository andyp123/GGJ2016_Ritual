using System;
using UnityEngine;

[RequireComponent (typeof (Camera))]
public class MouseLook : MonoBehaviour
{
	public float mouseSensitivity = 100.0f;
	public float clampAngle = 80.0f;
	public bool showCursor = true;

	public float zoomFov = 30.0f;
	private float defaultFov = 60.0f;
	private Camera cam;

	private float rotY = 0.0f; // rotation around the up/y axis
	private float rotX = 0.0f; // rotation around the right/x axis

	void Start ()
	{
		cam = gameObject.GetComponent<Camera>();
		defaultFov = cam.fieldOfView;

		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;

		Cursor.visible = showCursor;
	}

	void Update ()
	{
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = -Input.GetAxis("Mouse Y");

		rotY += mouseX * mouseSensitivity * Time.deltaTime;
		rotX += mouseY * mouseSensitivity * Time.deltaTime;

		rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);

		Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
		transform.rotation = localRotation;

		if (Input.GetButton("Fire2"))
		{
			cam.fieldOfView = zoomFov;
		}
		else
		{
			cam.fieldOfView = defaultFov;
		}
	}
}
