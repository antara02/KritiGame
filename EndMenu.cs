using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

    }

    public void Quit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }

    public void Try()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2); 
    }

    public void PlayGame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);  
    }

    public void Instructions()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Play()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void Back()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}