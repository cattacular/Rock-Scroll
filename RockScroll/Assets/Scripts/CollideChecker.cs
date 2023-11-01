
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This tester allows for you to use space to change the placement of the key,
/// so that way you know the audio will only play when the colliders are hitting
/// and you press A
/// </summary>


public class CollideChecker : MonoBehaviour
{
    AudioSource audioSource;
    private int clickCount = 0;

    public KeyCode theKey = KeyCode.None;

    //Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

   
        //audioSource.Play();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Activator")
        {
            clickCount = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Activator")
        {
            clickCount = 0;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Activator"
            && (Input.GetKeyDown(theKey)) && clickCount == 0)
        {
            //if (Input.GetKeyDown("A"))
        //    if (Input.GetKey(KeyCode.A))
        //{ 
                audioSource.Play();
            clickCount = clickCount + 1;
            //}
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 5);

        }
    }
}