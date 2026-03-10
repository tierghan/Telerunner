using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManagerScript : MonoBehaviour
{
    private bool started = false;
    private bool running = false;

    public float terrainStopper = 1f;

    public float terrainSpeed = 5e-06f;
    public float speedIncreaseRate = 0.00000005f;

    GameObject border;
    GameObject background;

    
    public List<GameObject> terrainList;
    
    // Start is called before the first frame update
    void Start()
    {
        terrainList = new List<GameObject>(Resources.LoadAll<GameObject>("Terrain"));
        border = GameObject.FindWithTag("Border");
        background = GameObject.FindWithTag("Background");
    }

    // Update is called once per frame
    void Update()
    {
        if (started == true && running == false)
        {
            generateTerrain();
            running = true;
        }
        else if(Time.time >=5f && started == false)
            {
                started = true;
            }
        else
        {
            terrainSpeed += (speedIncreaseRate*terrainStopper);
            border.transform.position = new Vector3(border.transform.position.x - (terrainSpeed+(terrainSpeed/2)), border.transform.position.y, border.transform.position.z);
            background.transform.position = new Vector3(background.transform.position.x - (terrainSpeed + (terrainSpeed/4)), background.transform.position.y, background.transform.position.z);
            if (background.transform.position.x <= -37f)
            {
                background.transform.position = new Vector3(3f, background.transform.position.y, background.transform.position.z);
            }
            if (border.transform.position.x <= -40f)
            {
                border.transform.position = new Vector3(0f, border.transform.position.y, border.transform.position.z);
            }
        }
    }

    public void generateTerrain()
    {
        Instantiate(terrainList[Random.Range(0, terrainList.Count)], new Vector3(20, 4.5f, 0), Quaternion.identity);
    }

    public void speedBoost()
    {
        Debug.Log("Speed Boost Activated");
        terrainSpeed += speedIncreaseRate*200;
    }

    public void speedReduce()
    {
        Debug.Log("Speed Reduce Activated");
        terrainSpeed -= speedIncreaseRate*200;
    }
}
