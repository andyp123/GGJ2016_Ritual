using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameUI : MonoBehaviour
{
  public Text _ouijaSentence;
  public Text _subtitle;

  public float _subtitleHideDelay = 2.0f;
  private float _subtitleHideTime = 0.0f;

  void Awake ()
  {
    _ouijaSentence.transform.parent.gameObject.SetActive(false);
    _ouijaSentence.text = "";
    _subtitle.text = "";
  }

  void Update ()
  {
    if (_subtitle.text != "" && Time.time > _subtitleHideTime)
    {
      _subtitle.text = "";
    }
  }

  public void SetOuijaSentence (string sentence)
  {
    _ouijaSentence.text = sentence;
    _ouijaSentence.transform.parent.gameObject.SetActive(_ouijaSentence.text != "");
  }

  public void SetSubtitle (string subtitle, Color? color = null)
  {
    _subtitle.text = subtitle;
    _subtitle.color = color ?? Color.white;
    _subtitleHideTime = Time.time + _subtitleHideDelay;
  }
}

