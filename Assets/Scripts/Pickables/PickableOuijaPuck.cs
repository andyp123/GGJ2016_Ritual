using UnityEngine;
using System.Collections;

public class PickableOuijaPuck : PickableObject
{
  public WorldInteraction WorldInteraction;

  public float moveSpeed = 0.05f;
  public float mouseSensitivity = 5.0f;
  public float maxRotation = 30.0f;
  public float maxMoveX = 0.2f;
  public float maxMoveY = 0.13f;

  private bool grabbed = false;

  void Update ()
  {
    float x, z = 0.0f;
    Vector3 moveDir = Vector3.zero;

    if (grabbed)
    {
      int layerMask = 1 << LayerMask.NameToLayer("OuijaBoard");
      Vector3 lookAtPosition = Vector3.zero;
      if (WorldInteraction.GetLookAtPosition(layerMask, out lookAtPosition))
      {
        transform.position = lookAtPosition;
      }
    }
    else
    {
      // use keyboard/joypad
      x = Input.GetAxis("Horizontal");
      z = Input.GetAxis("Vertical");
      moveDir = new Vector3(x, 0.0f, z).normalized;

      transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }

    float rotAngle = transform.localPosition.x / maxMoveX * maxRotation;
    transform.localRotation = Quaternion.Euler(0.0f, rotAngle, 0.0f);
  }

  public override void FocusGained()
  {
    Debug.Log(transform.name + " FocusGained (PUCK)");
  }

  public override void FocusLost()
  {
    Debug.Log(transform.name + " FocusLost (PUCK)");
  }

  public override void Activate()
  {
    grabbed = true;
  }

  public override void Deactivate()
  {
    grabbed = false;
  }
}