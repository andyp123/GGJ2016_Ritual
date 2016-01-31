using UnityEngine;
using System.Collections;

public class PickableObject : MonoBehaviour
{
  public virtual void FocusGained()
  {
    Debug.Log(transform.name + " FocusGained");
  }

  public virtual void FocusLost()
  {
    Debug.Log(transform.name + " FocusLost");
  }

  public virtual void Activate()
  {
    Debug.Log(transform.name + " Activate");
  }
  public virtual void Deactivate()
  {
    Debug.Log(transform.name + " Deactivate");
  }
}
