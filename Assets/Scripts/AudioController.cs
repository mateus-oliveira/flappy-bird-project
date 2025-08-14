using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    public static AudioController instance;

    void Awake () {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void StopAudio() {
        sound.Stop();
    }

    public void PlayAudio(AudioClip audio, bool loop=false) {
        sound.clip = audio;
        sound.Play();
        sound.loop = loop;
    }
}
