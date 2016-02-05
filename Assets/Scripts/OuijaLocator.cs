using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OuijaLocator : MonoBehaviour
{
  public GameUI gameUI;

  public GameObject ouijaPuck;
  public float distanceThreshold = 0.02f;
  public float puckRestThreshold = 0.75f;
  public float puckWobbleThreshold = 0.001f;


  private Transform nearestLocator;
  private Transform previousLocator;
  private Vector3 puckLastPos;
  private float puckRestTime = 0.0f;

  private OuijaQuestionMap questionMap;
  private string currentSentence = "";

	void Start ()
  {
    questionMap = gameObject.GetComponent<OuijaQuestionMap>();
    puckLastPos = ouijaPuck.transform.position;
	}
	
	void Update ()
  {
    float wobbleDistance = (ouijaPuck.transform.position - puckLastPos).magnitude;
    puckRestTime = (wobbleDistance <= puckWobbleThreshold) ? puckRestTime += Time.deltaTime : 0.0f;

    if (puckRestTime >= puckRestThreshold)
    {
      UpdateNearestLocator();
      if (nearestLocator != null && nearestLocator != previousLocator)
      {
        switch (nearestLocator.name)
        {
          case "ASK":
            if (currentSentence.Length > 0 )
              AskQuestion(currentSentence);
            currentSentence = "";
            gameUI.SetOuijaSentence(""); 
            break;
          case "GOODBYE":
            currentSentence = "";
            gameUI.SetOuijaSentence(""); 
            break;
          case "YES":
          case "NO":
            currentSentence = nearestLocator.name;
            break;
          default:
            currentSentence += nearestLocator.name;
            break;
        }
        if (currentSentence.Length > 0)
        {
          gameUI.SetOuijaSentence(currentSentence);
        }
      }
    }

    puckLastPos = ouijaPuck.transform.position;
	}

  void UpdateNearestLocator ()
  {
    Transform currentNearest = transform;
    Vector3 puckPos = ouijaPuck.transform.position;
    float nearestDistance = 9999999.0f;

    foreach (Transform child in transform)
    {
      float distance = (child.position - puckPos).magnitude;
      if (distance < nearestDistance)
      {
        nearestDistance = distance;
        currentNearest = child;
      }
    } 

    if (nearestDistance < distanceThreshold)
    {
      previousLocator = nearestLocator;
      nearestLocator = currentNearest;
    }
    else
    {
      nearestLocator = null;
    } 
  }

  void AskQuestion (string question)
  {
    QuestionInfo q;
    if (questionMap.GetQuestionInfo(question, out q))
    {
      gameUI.SetSubtitle(q.englishString);
      StartCoroutine (GameManager.instance.eventManager.TriggerEvent(q.targetEventName, q.targetEventDelay));
    }
    else
    {
      Debug.Log("I can't answer your question.");
    }
  }
}
