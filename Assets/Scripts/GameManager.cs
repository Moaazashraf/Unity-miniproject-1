using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float currentHealth = 3.0f;
    public float maxHealth = 3.0f;
    public int score;
    int points = 0;
    public Text scoreText;
    public static GameManager inst;
    public Movement movement;
    public void IncrementScore()
    {
        points+=1;
        if ((points % 5 == 0) & (points > 0.0) )
        {
            Debug.Log(movement.speed);
            movement.speed = movement.speed + 2.0f;
        }
        score+=10;
        scoreText.text = "Score: " + score;
    }

    public void DecrementScore()
    {
        score-=5;
        scoreText.text = "Score: " + score;
    }

     public void IncrementHealth()
    {
        if ( currentHealth < 3 )
        {
            currentHealth++;
        }
    }

    public void DecrementHealth()
    {
        currentHealth--;
    }

    void Awake()
    {
        inst =  this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
