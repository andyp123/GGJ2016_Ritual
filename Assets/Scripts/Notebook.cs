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
    Text newNote = Object.Instantiate(_sampleText) as Text;
    //newNote.posY = _notes.Length * newNote.height;
    newNote.text = note;
    newNote.transform.name = "note";
    newNote.transform.SetParent(_sampleText.transform.parent, false);
    newNote.gameObject.SetActive(true);
    _notes.Add(newNote);
  }
}
