using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Credits"); //Loads into our first level when pressing play
    }
    public void QuitGame()
    {
        Application.Quit(); //This quits the game duhh
    }

}
