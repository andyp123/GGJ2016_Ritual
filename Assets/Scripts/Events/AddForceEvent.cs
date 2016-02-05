using UnityEngine;
using System.Collections;

public class AddForceEvent : GameEvent
{
  public GameObject target;
  public Transform forceOrigin;
  public Transform forceTarget;
  public float forceMagnitude = 1.0f;
  public float forceDuration = 0.1f;

  private Rigidbody rb;
  private float forceApplyStartTime = 0.0f;
  private float forceApplyEndTime = 0.0f;
  private Vector3 forceDirection = Vector3.up;

  void Start ()
  {
    rb = target.gameObject.GetComponent<Rigidbody>();
    if (rb == null)
      Debug.LogWarning( "GameObject has no Rigidbody component" );

    forceDirection = (forceTarget.position - forceOrigin.position).normalized;

    GameManager.instance.eventManager.AddEvent( this );
  }


  void Update ()
  {
    if (Time.time > forceApplyStartTime && Time.time < forceApplyEndTime)
    {
      ApplyForce();
    }
  }


  public override void Trigger ()
  {
    forceApplyStartTime = Time.time;
    forceApplyEndTime = forceApplyStartTime + forceDuration;

    ApplyForce(); // apply first frame of force
  }

  void ApplyForce ()
  {
    //float t = (forceDuration > 0.0f) ? (Time.time - forceApplyStartTime) / forceDuration : 1.0f; // should be used to apply force curve
    Vector3 force = forceDirection * forceMagnitude;

    rb.AddForceAtPosition(force, forceOrigin.position);
  }
}
