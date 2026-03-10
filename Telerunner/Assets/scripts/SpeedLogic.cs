using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLogic : MonoBehaviour
{
    public int boostType = 0;
    // 0 = Speed Boost
    // 1 = Speed Reduce

    GameObject terrainManager;

    void Start()
    {
        terrainManager = GameObject.FindWithTag("TerrainManager");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (boostType == 0)
            {
                terrainManager.GetComponent<TerrainManagerScript>().speedBoost();
            }
            else if (boostType == 1)
            {
                Debug.Log("Speed Reduce Requested");
                terrainManager.GetComponent<TerrainManagerScript>().speedReduce();
            }
        }
    }

}
