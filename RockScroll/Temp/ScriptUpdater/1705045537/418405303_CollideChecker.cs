using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideChecker : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {

        if (other.tag == "Activator")
            GetComponent<AudioSource>().Play();

    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
