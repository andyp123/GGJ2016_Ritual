using UnityEngine;
using System.Collections;

public class PickableRadio : PickableObject
{
  public AudioSource radioStatic;

  void Start()
  {
    radioStatic.Play();
    radioStatic.Pause();
  }

  public override void FocusGained()
  {
    Debug.Log(transform.name + " FocusGained (RADIO)");
  }

  public override void FocusLost()
  {
    Debug.Log(transform.name + " FocusLost (RADIO)");
  }

  public override void Activate()
  {
    if (radioStatic.isPlaying)
    {
      radioStatic.Pause();
    }
    else
    {
      radioStatic.UnPause();
    }
  }

  public override void Deactivate()
  {
  }
}
