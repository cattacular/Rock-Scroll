using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonPress3a: MonoBehaviour
{
    public GameObject ButtonPressed;






    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("Level1");
    }

    private void CancelInvoke()
    {
        SceneManager.LoadScene("Controls - Main Menu");
    }
}
