using UnityEngine;
using System.Collections;

[System.Serializable]
public class QuestionInfo
{
  public string englishString;
  public string ouijaString;
  public bool active = false;
  public string englishAnswer = "";
  public string targetEventName = "";
  public float targetEventDelay = 0.0f;
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
	
  public bool GetQuestionInfo (string question, out QuestionInfo questionInfo)
  {
    foreach (QuestionInfo q in questions)
    {
      if (q.active && q.ouijaString == question)
      {
        questionInfo = q;
        return true;
      }
    }

    questionInfo = new QuestionInfo(); // FIXME: UGH. Maybe you are using 'out' incorrectly?
    return false;
  }
}
