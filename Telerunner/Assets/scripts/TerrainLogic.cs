using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainLogic : MonoBehaviour
{
    bool replacedSelf = false;
    GameObject TerrainManager;

    float terrainSpeed;
    // Start is called before the first frame update
    void Start()
    {
        TerrainManager = GameObject.FindWithTag("TerrainManager");
        terrainSpeed = TerrainManager.GetComponent<TerrainManagerScript>().terrainSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x - terrainSpeed, this.transform.position.y, this.transform.position.z);
        terrainSpeed = TerrainManager.GetComponent<TerrainManagerScript>().terrainSpeed;
        if (this.transform.position.x <= -20f)
        {
            Destroy(this.gameObject);
        }
        else if (this.transform.position.x <= -5f && replacedSelf == false)
        {
            replacedSelf = true;
            TerrainManager.GetComponent<TerrainManagerScript>().generateTerrain();
        }
    }
}
