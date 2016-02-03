using UnityEngine;
using System.Collections;

[System.Serializable]
public struct AudioSettings
{
  public float sourceVolume;
  public float lowPassCutoffFrequency;
}

public class AudioAdjust : MonoBehaviour
{
  public AudioSource[] audioSources;

  public AudioSettings[] audioSettings;
  public int firstSettingIndex = 0;

  private int currentSettingIndex = 0;

  void Start ()
  {
    currentSettingIndex = firstSettingIndex;
    ApplyAudioSettings();
  }
	
	void Update ()
  {
	  if (Input.GetKeyDown(KeyCode.N))
    {
      currentSettingIndex += 1;
      if (currentSettingIndex >= audioSettings.Length)
        currentSettingIndex = 0;

      ApplyAudioSettings();
    }
	}

  void ApplyAudioSettings()
  {
    AudioSettings settings = audioSettings[currentSettingIndex];

    foreach (AudioSource audioSource in audioSources)
    {
      if (audioSource != null)
      {
        audioSource.volume = settings.sourceVolume;
      
        AudioLowPassFilter lowPass = audioSource.gameObject.GetComponent<AudioLowPassFilter>();
        if (lowPass != null)
        {
          lowPass.cutoffFrequency = settings.lowPassCutoffFrequency;
        }
      }
    }
  }

}
