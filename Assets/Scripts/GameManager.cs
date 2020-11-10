using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float currentHealth = 3.0f;
    public float maxHealth = 3.0f;
    public int score;
    public Text scoreText;
    public static GameManager inst;
    public void IncrementScore()
    {
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
        currentHealth++;
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
