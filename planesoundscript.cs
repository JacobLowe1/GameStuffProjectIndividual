using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planesoundscript : MonoBehaviour
{
    public float interval;
    public AudioSource planesound;

    void Start()
    {
        planesound = GetComponent<AudioSource>();
        planesound.PlayDelayed(2.0f);

        Destroy(gameObject, interval);
    }
    

}
