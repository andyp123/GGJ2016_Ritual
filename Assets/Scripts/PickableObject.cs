using UnityEngine;
using System.Collections;

public class PickableObject : MonoBehaviour
{
  public virtual void FocusGained()
  {
    Debug.Log("PickableObject FocusGained");
  }

  public virtual void FocusLost()
  {
    Debug.Log("PickableObject FocusLost");
  }

  public virtual void Interact()
  {
    Debug.Log("PickableObject Interact");
  }
}
