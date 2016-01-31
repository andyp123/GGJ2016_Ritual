using UnityEngine;
using System.Collections;

public class OuijaGUI : MonoBehaviour
{

  public string ouijaText = "";

  private Rect textArea;

	void Start ()
  {
    textArea = new Rect( 0, 0, Screen.width, Screen.height );
	}
	
	void Update ()
  {
	}

  void OnGUI ()
  {
    GUI.Label( textArea, ouijaText );
  }
}
