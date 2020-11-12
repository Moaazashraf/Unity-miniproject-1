using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;
    
    Renderer playerRenderer;
    Renderer coinRenderer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            GameObject.Destroy(gameObject);
            return;
        }

        if (other.gameObject.CompareTag("Player"))
        {
            playerRenderer = other.gameObject.GetComponent<Renderer>();
            coinRenderer = gameObject.GetComponent<Renderer>();

            if(coinRenderer.material.color == playerRenderer.material.color)
            {
                if (GameManager.inst.flipped)
                {
                    GameManager.inst.DecrementScore();
                }
                else
                {
                    GameManager.inst.IncrementScore();
                }
            }
            else
            {
                if (GameManager.inst.flipped)
                {
                    GameManager.inst.IncrementScore();
                }
                else
                {
                    GameManager.inst.DecrementScore();
                }
            }
        }



        GameObject.Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
