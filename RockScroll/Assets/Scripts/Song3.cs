using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Song3 : MonoBehaviour
{
    public GameObject ButtonPressed;






    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene("Level1");
    }

    private void CancelInvoke()
    {
        SceneManager.LoadScene("Song3");
    }
}
