using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private PlayerController playerControllerScript;
    private Vector3 spawnPos = new Vector3(21, 0, 2);
 

    private float startDelay = 2;
    private float repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);     
        playerControllerScript = GameObject.Find("Player1").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false){
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }

}
