using UnityEngine;
using System.Collections;

// FIXME: this is really shit and could be made in a more fail-proof way

[RequireComponent (typeof(EventManager))]
public class GameManager : MonoBehaviour
{
  public static GameManager instance = null;

  public EventManager eventManager;
  public GameUI gameUI;
  public OuijaLocator ouijaLocator;
  public Notebook notebook;

  void Awake ()
  {
    if (instance == null)
    {
      instance = this;
    }
    else if (instance != this)
    {
      Destroy(gameObject);
    }

    DontDestroyOnLoad(gameObject);
  }
}
