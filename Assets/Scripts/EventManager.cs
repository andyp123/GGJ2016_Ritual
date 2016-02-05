using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GameEventList
{
  private List<GameEvent> _events;


  public GameEventList ()
  {
    _events = new List<GameEvent>();
  }


  public void TriggerEvents ()
  {
    foreach (GameEvent e in _events)
    {
      e.Trigger();
    }
  }

  public void AddEvent (GameEvent e)
  {
    _events.Add(e);
  }

}



public class EventManager : MonoBehaviour
{
  private Dictionary<string, GameEventList> _eventMap;


  void Awake ()
  {
    _eventMap = new Dictionary<string, GameEventList>();
  }


  public IEnumerator TriggerEvent (string eventName, float triggerDelay = 0.0f)
  {
    yield return new WaitForSeconds(triggerDelay);

    if (_eventMap.ContainsKey(eventName))
    {
      _eventMap[eventName].TriggerEvents();
    }
  }


  public void AddEvent (GameEvent e)
  {
    if (e == null || e.eventName == "")
      return;

    GameEventList eventList;

    if (_eventMap.ContainsKey(e.eventName))
    {
      eventList = _eventMap[e.eventName];
      eventList.AddEvent(e);
    }
    else
    {
      eventList = new GameEventList();
      eventList.AddEvent(e);
      _eventMap.Add(e.eventName, eventList);
    }
  }

}
