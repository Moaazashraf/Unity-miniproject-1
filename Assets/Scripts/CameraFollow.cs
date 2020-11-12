using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    bool lookup;

    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 targetPos = player.position + offset;
        targetPos.x = 0;
        targetPos.y = 2.5f;
        transform.position = targetPos;
        Vector3 targetDirection = player.position - transform.position;
        float singleStep = 2.0f * Time.deltaTime;
        targetDirection.x = 0;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);


    }
}
