﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameManager.inst.DecrementHealth();
        GameObject.Destroy(gameObject);
    }
}
