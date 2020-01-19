using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject BigExplosionEffect;
    public AudioSource Boom;
    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 1f);
    }

    void Update ()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            Instantiate(BigExplosionEffect, transform.position, Quaternion.identity);
            Boom = GetComponent<AudioSource>();
        }
    }
}
