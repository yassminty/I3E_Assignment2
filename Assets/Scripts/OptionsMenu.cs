using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Music", volume);
    }

        public void SetSFXVolume(float sfx)
    {
        audioMixer.SetFloat("SFX", sfx);
    }
    
}
