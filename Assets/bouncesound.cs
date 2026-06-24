using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncesound : MonoBehaviour
{
    AudioSource audioPlayer;
        public AudioClip bounceFX;
    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision col){
        
            audioPlayer.PlayOneShot(bounceFX, 1f);
        }
}
