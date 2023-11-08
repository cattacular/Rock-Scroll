
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public bool createMode = false;
    AudioSource audioSource;
    private int clickCount = 0;
    public KeyCode theKey;
    bool active = false;
    GameObject note;
    public GameObject createdNote;

    // this script allows for the deleting of notes when they collide with the
    // and the specific key is pressed. 
    //Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.mute = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "note")
        {
            note = other.gameObject;
            active = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "note")
        {
            //GetComponent<Rigidbody2D>().position = Vector2.down * 10;
            active = false;
        }
    }

    private void Update()
    {
        if(createMode && Input.GetKeyDown(theKey))
        {
            Instantiate(createdNote, transform.position, Quaternion.identity);
        }
        else
        {
            if(Input.GetKeyDown(theKey)&& active)
            {
                Destroy(note);
                audioSource.mute = false;

            }
        }
       
    }
}

 
// I didn't want to lose this code but it works for muting/unmuting
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

///// <summary>
///// This tester allows for you to use space to change the placement of the key,
///// so that way you know the audio will only play when the colliders are hitting
///// and you press A
///// </summary>


//public class ColliderCheckker : MonoBehaviour
//{
//    AudioSource audioSource;
//    private int clickCount = 0;
//    public KeyCode theKey = KeyCode.None;
//    bool active = false;
//    GameObject note;

//    //Start is called before the first frame update
//    void Start()
//    {
//        audioSource = GetComponent<AudioSource>();
//        audioSource.mute = true;

//        //audioSource.Play();
//    }



//    private void OnTriggerEnter2D(Collider2D other)
//    {
//        if (other.tag == "Activator")
//        {
//            clickCount = 0;
//            //audioSource.Play();
//            active = true;

//        }
//    }

//    private void OnTriggerExit2D(Collider2D other)
//    {
//        if (other.tag == "Activator")
//        {
//            //audioSource.mute = true;
//            GetComponent<Rigidbody2D>().position = Vector2.down * 10;
//            clickCount = 0;
//            active = false;
//        }
//    }

//    private void OnTriggerStay2D(Collider2D other)
//    {

//        if (other.tag == "Activator")
//        {


//            audioSource.mute = false;
//            clickCount = 1;
//        }
//    }
//}


