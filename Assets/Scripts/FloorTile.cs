using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    FloorSpawner groundSpawner;
    //public GameObject wall1Tile;
    //public GameObject wall2Tile;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject YellowCoin;
    public GameObject RedCoin;
    public GameObject BlueCoin;



    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<FloorSpawner>();
        SpawnObstacle();
        SpawnOCoin();
    }

    
    void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(2, 8);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        if (obstacleSpawnIndex == 7)
        {
            Instantiate(obstacle3, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            if (obstacleSpawnIndex == 5 || obstacleSpawnIndex == 6)
            {
                Instantiate(obstacle2, spawnPoint.position, Quaternion.identity, transform);
            }
            else
            {
                Instantiate(obstacle1, spawnPoint.position, Quaternion.identity, transform);
            }
        }
    }

    void SpawnOCoin()
    {
        GameObject[] coins = {RedCoin, YellowCoin, BlueCoin};
        int coinIndex = Random.Range(0, 3);
        GameObject temp = Instantiate(coins[coinIndex], transform);
        temp.transform.position = GetRondomPosition(GetComponent<Collider>());
    }

    Vector3 GetRondomPosition(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        point.y = 1;
        return point;
    }
}
