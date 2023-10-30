using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public KeyCode key;
    bool active = false;
    GameObject note;

    // Start is called before the first frame update
    void Start()
    {
        note = null; // Initialize note as null
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key) && active)//&& note != null)
        {
            Debug.Log("Deleting Note");
            Destroy(note);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Note")) // Check the tag of the entering object
        {
            Debug.Log("Entered Trigger Zone");
            active = true;
            note = col.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Note")) // Check the tag of the exiting object
        {
            Debug.Log("Exited Trigger Zone");
            active = false;
            note = null; // Clear the note when exiting the trigger
        }
    }
}
