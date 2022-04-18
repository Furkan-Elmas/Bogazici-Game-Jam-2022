using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;


    public void setVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }
}
