using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume) // set the volume of the music
    {
        audioMixer.SetFloat("Music", volume);
    }

    public void SetSFXVolume(float sfx) // set the volume of the sound effects
    {
        audioMixer.SetFloat("SFX", sfx);
    }
    
}
