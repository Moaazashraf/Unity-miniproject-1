﻿using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floorTile;
    Vector3 nextSpawnPoint1;
   

    public void SpawnTile()
    {
        GameObject temp1 = Instantiate(floorTile, nextSpawnPoint1, Quaternion.identity);
        nextSpawnPoint1 = temp1.transform.GetChild(1).transform.position;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
        SpawnTile();
    }
}