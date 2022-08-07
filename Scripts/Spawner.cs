using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Player player;
    public GameObject obstaclePrefab;
    private float randomHeight, randomWidth;
    private Vector3 spawnPosition;
    public float startDelay = 2, repeatRate = 2;

    // Start is called before the first frame update
    void Start()
    {
        

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        player = FindObjectOfType<Player>();
    }

    void SpawnObstacle()
    {
        startDelay = Random.Range(0, 3);
        repeatRate = Random.Range(0, 3);
        //randomWidth = Random.Range(9, 12);
        randomHeight = Random.Range(-3.7f, -2f);
        spawnPosition = new Vector3(6.5f, randomHeight, 0);

        if (player.gameOver == false && player.gameStart == false)
        {
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
        }
    }
}
