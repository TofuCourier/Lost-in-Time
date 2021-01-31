using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLevel1 : MonoBehaviour
{    public void PlayLevel()
    {
        SceneManager.LoadScene("Credits"); //Loads into our first level when pressing play
    }


}
