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
        music1.PlayDelayed(2.0f);

        Destroy(gameObject, interval);
    }

}
