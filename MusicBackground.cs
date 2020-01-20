using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBackground : MonoBehaviour
{
    public float interval;
    public AudioSource music1;
    
    void Start()
    {
        music1 = GetComponent<AudioSource>();
        music1.Play();

        Destroy(gameObject, interval);
    }

}
