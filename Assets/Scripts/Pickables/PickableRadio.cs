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
  }

  public override void FocusLost()
  {
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
