using UnityEngine;
using System.Collections;

public class PickableNote : PickableObject
{
  public string note;

  public override void FocusGained()
  {
    Debug.Log(transform.name + " FocusGained (NOTE)");
  }

  public override void FocusLost()
  {
    Debug.Log(transform.name + " FocusLost (NOTE)");
  }

  public override void Activate()
  {
    Debug.Log(note);
  }

  public override void Deactivate()
  {
  }
}
