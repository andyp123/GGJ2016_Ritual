using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Notebook : MonoBehaviour
{
  public Text _sampleText;
  public int _maxNotesPerPage = 8;

  private List<Text> _notes;

  void Awake ()
  {
    _notes = new List<Text>();
  }

  public void AddNote (string note)
  {
    if (_notes.Count < _maxNotesPerPage)
    {
      Text newNote = Object.Instantiate(_sampleText) as Text;
      newNote.text = note;
      newNote.transform.name = "note";
      newNote.rectTransform.SetParent(_sampleText.rectTransform.parent, false);
      newNote.rectTransform.Translate(new Vector3(0.0f, -80.0f * _notes.Count * 0.000210975f, 0.0f)); //FIXME: hack
      newNote.gameObject.SetActive(true);
      _notes.Add(newNote);
    }
  }
}
