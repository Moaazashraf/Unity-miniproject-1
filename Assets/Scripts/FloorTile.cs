using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTile : MonoBehaviour
{
    FloorSpawner groundSpawner;
    //public GameObject wall1Tile;
    //public GameObject wall2Tile;
    public float timer = 0.0f;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject YellowCoin;
    public GameObject RedCoin;
    public GameObject BlueCoin;
    public GameObject HealthCube;



    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<FloorSpawner>();
        SpawnObstacle();
        SpawnCollictor();
        SpawnObstaclef();


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

    void SpawnObstaclef()
    {
        int obstacleSpawnIndex = Random.Range(9, 15);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        if (obstacleSpawnIndex == 14)
        {
            Instantiate(obstacle3, spawnPoint.position, Quaternion.identity, transform);
        }
        else
        {
            if (obstacleSpawnIndex == 13 || obstacleSpawnIndex == 12)
            {
                Instantiate(obstacle2, spawnPoint.position, Quaternion.identity, transform);
            }
            else
            {
                Instantiate(obstacle1, spawnPoint.position, Quaternion.identity, transform);
            }
        }
    }

    void SpawnCollictor()
    {
        
        GameObject[] Collictors = {RedCoin, YellowCoin, BlueCoin, HealthCube };
        int collictorsIndex = Random.Range(0, 4);
        GameObject temp = Instantiate(Collictors[collictorsIndex], GetRondomPosition(GetComponent<Collider>()), Quaternion.identity, transform);
        GameObject tempf = Instantiate(Collictors[collictorsIndex], GetRondomPositionf(GetComponent<Collider>()), Quaternion.identity, transform);

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
     Vector3 GetRondomPositionf(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z));
        point.y = 4;
        return point;
    }

    void Update()
    {
      
    }
}
