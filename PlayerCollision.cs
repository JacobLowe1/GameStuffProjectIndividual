using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject levelFailUI, BigExplosionEffect;
    public AudioClip musicloss1;

    void Start()
    {
        levelFailUI.SetActive(false);
    
    }

    void Update ()
    {
       
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            levelFailUI.SetActive(true);
            Instantiate(BigExplosionEffect, transform.position, Quaternion.identity);
            gameObject.SetActive (false);
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(musicloss1);
            Destroy(GameObject.FindWithTag("SoundMusic"));
            Destroy(GameObject.FindWithTag("BackgroundMusic"));
        }
    }

}
