using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject terrainManager;
    GameObject gameOverUI;
    GameObject textManager;
    AudioSource audio;
    public float stopwatch;
    // Start is called before the first frame update
    void Start()
    {
        terrainManager = GameObject.FindWithTag("TerrainManager");
        gameOverUI = GameObject.Find("GameOverUI");
        textManager = GameObject.Find("TextManager");
        audio = GetComponent<AudioSource>();
        gameOverUI.SetActive(false);
        Invoke("startGeneration",5);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void startGeneration()
    {
        terrainManager.GetComponent<TerrainManagerScript>().generateTerrain();
    }
    

    public void gameOver(int finalScore)
    {
        stopwatch = Time.time;
        gameOverUI.SetActive(true);
        textManager.GetComponent<TextManager>().displayText(finalScore, stopwatch);
        Debug.Log("Game Over! Final Score: " + finalScore + " Time: " + stopwatch);
        terrainManager.GetComponent<TerrainManagerScript>().terrainStopper = 0f;
        terrainManager.GetComponent<TerrainManagerScript>().terrainSpeed = 0f;
        audio.Play();
    }

    public void Retry()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName, LoadSceneMode.Single);
    }

    public void MainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
