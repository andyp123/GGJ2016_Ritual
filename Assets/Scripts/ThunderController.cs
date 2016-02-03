using UnityEngine;
using System.Collections;

public class ThunderController : MonoBehaviour
{
  public AudioSource audioSource;
  public AudioClip[] audioClips;
  public float minDelay = 5.0f;
  public float maxDelay = 20.0f;

  private float nextPlayTime = 0.0f;

	void Start ()
  {
    if (audioClips.Length < 1)
    {
      Debug.LogWarning("No AudioClips to play.");
      Destroy (this);
	  }
  }
	
	void Update ()
  {
	  if (Time.time > nextPlayTime)
    {
      PlayClip();
    }
	}

  void PlayClip ()
  {
    int clipIndex = Random.Range(0, audioClips.Length);

    audioSource.Stop();
    audioSource.Play();

    nextPlayTime = Time.time + Random.Range(minDelay, maxDelay) + audioClips[clipIndex].length;
  }
}
