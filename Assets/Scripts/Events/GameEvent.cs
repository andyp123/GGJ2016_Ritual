using UnityEngine;
using System.Collections;

public abstract class GameEvent : MonoBehaviour
{
  public string eventName = "";

  public virtual void Trigger ()
  {
  }
}
