using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject floorTile;
    public GameObject roofTile;
    Vector3 nextSpawnPoint1;
    Vector3 nextSpawnPoint2;
   

    public void SpawnTile()
    {
        GameObject temp1 = Instantiate(floorTile, nextSpawnPoint1, Quaternion.identity);
        nextSpawnPoint1 = temp1.transform.GetChild(1).transform.position;
        GameObject temp2 = Instantiate(roofTile, nextSpawnPoint2, Quaternion.identity);
        nextSpawnPoint2 = temp2.transform.GetChild(1).transform.position;
        nextSpawnPoint2.y = 7;
        // nextSpawnPoint2.Rotate(0,0,180);
        Debug.Log(nextSpawnPoint1);
        
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