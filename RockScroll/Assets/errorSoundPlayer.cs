using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class errorSoundPlayer : MonoBehaviour
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
            audioSource.Play();
        }
    }

}
