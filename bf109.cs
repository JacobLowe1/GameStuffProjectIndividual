using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bf109 : MonoBehaviour
{

    public GameObject BigExplosionEffect;
    public AudioSource bigboom;

    void Start()
    {
        bigboom = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Instantiate(BigExplosionEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            bigboom.Play();
        }
    }
}
