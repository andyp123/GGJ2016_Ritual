using UnityEngine;
using System.Collections;

public class PickableAddNote : PickableObject
{
  public string note;
  public bool focusActivation = false; // triggered by looking at it
  public float focusTime = 0.0f;
  public bool showSubtitle = true;
  public string subtitle = "";

  public Notebook notebook;
  public GameUI gameUI;

  private bool focused = false;
  private float focusCheckTime = 0.0f;

  void Start ()
  {
    if (notebook == null)
      Debug.LogWarning("No Notebook object assigned.");

    if (showSubtitle)
    {
      if (subtitle == "")
        AssignSubtitleFromNote();
      if (gameUI == null)
        Debug.LogWarning ("No GameUI object assigned.");
    }
  }

  void Update ()
  {
    if (focusActivation && focused && Time.time > focusCheckTime)
    {
      notebook.AddNote(note);
      if (showSubtitle)
        gameUI.SetSubtitle(subtitle);
      Destroy(this);
    }
  }

  void AssignSubtitleFromNote()
  {
    subtitle = note;
    int chPos = subtitle.IndexOf('[');
    subtitle.Remove(chPos, 1);
    chPos = subtitle.IndexOf(']');
    subtitle.Remove(chPos, 1);
  }

  public override void FocusGained ()
  {
    focused = true;
    focusCheckTime = Time.time + focusTime;
  }

  public override void FocusLost ()
  {
    focused = false;
    focusCheckTime = 0.0f;
  }

  public override void Activate ()
  {
    if (!focusActivation )
    {
      notebook.AddNote(note);
      if (showSubtitle)
        gameUI.SetSubtitle(subtitle);
      Destroy(this);
    }
  }

  public override void Deactivate ()
  {
  }
}
