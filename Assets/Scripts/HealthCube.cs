using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCube : MonoBehaviour
{
    float turnSpeed = 90f;
    void OnTriggerEnter(Collider other)
    {
        GameManager.inst.IncrementHealth();
        GameObject.Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
    }
}
