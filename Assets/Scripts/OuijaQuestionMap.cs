using UnityEngine;
using System.Collections;

[System.Serializable]
public struct QuestionInfo
{
  public string englishString;
  public string ouijaString;
  public bool active;
  // texture coords
  // target event
}

public class OuijaQuestionMap : MonoBehaviour
{

  public QuestionInfo[] questions;

	void Start ()
  {
	
	}
	
	void Update ()
  {
	
	}
}
