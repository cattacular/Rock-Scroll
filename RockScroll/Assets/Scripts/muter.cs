using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muter : MonoBehaviour
{

    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "note")
        {
           audioSource.mute = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "note")
        {
            audioSource.mute = false;
        }
        if (other.tag == "mainMenu") {
            SceneManager.LoadScene("Main Menu");
    }
    }

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
