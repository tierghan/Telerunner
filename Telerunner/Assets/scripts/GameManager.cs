using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject terrainManager;
    // Start is called before the first frame update
    void Start()
    {
        terrainManager = GameObject.FindWithTag("TerrainManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver(int finalScore)
    {
        Debug.Log("Game Over! Final Score: " + finalScore);
        terrainManager.GetComponent<TerrainManagerScript>().terrainStopper = 0f;
        terrainManager.GetComponent<TerrainManagerScript>().terrainSpeed = 0f;
    }
}
