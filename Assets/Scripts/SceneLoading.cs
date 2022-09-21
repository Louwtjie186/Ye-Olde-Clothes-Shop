using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You have quit");
    }
}
