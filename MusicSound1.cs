using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSound1 : MonoBehaviour
{

    public AudioSource musicloss;


    // Start is called before the first frame update
    void Start()
    {
        musicloss = GetComponent<AudioSource>();
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            musicloss.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
