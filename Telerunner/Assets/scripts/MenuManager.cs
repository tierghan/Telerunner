using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("RunnerScene");
    }
    public void OpenCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");

    }
    public void CloseCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        
    }
}
