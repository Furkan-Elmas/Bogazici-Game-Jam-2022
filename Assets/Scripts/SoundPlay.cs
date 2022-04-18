using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    public AudioSource wolfSound;

    float timer;

    private void Start()
    {
        repeating();
    }
    void play()
    {
        timer = Random.Range(60f, 120f);
        wolfSound.Play();
        repeating();
    }
    void repeating()
    {
        Invoke("play", timer);
    }
}
