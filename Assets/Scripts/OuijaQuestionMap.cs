using UnityEngine;
using System.Collections;

[System.Serializable]
public struct QuestionInfo
{
  public string englishString;
  public string ouijaString;
  public bool active;
}

[System.Serializable]
public struct QuestionData
{
  public QuestionInfo[] questions;
}

public class OuijaQuestionMap : MonoBehaviour
{
  public TextAsset questionDataFile;
  public QuestionInfo[] questions;

	void Start ()
  {
    string questionJSON = questionDataFile.text;
    QuestionData questionData = JsonUtility.FromJson<QuestionData>(questionJSON);
    questions = questionData.questions;
	}
	
	void Update ()
  {
	
	}
}
