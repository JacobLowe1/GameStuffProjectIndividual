using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour

{

    public AudioSource musicwin;

    void Start()
    {
        levelCompleteUI.SetActive(false);
        musicwin = GetComponent<AudioSource>();
    }

    

    public GameObject levelCompleteUI;
    

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            levelCompleteUI.SetActive(true);

            musicwin.Play();

            StartCoroutine("Quit");

        }
    }

    IEnumerator Quit()
    {
        yield return new WaitForSeconds(2);
        Application.Quit();
    }

}
