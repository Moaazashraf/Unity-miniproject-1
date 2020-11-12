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
    public bool flipped;
    AudioSource[] MyAudioSources;
    public GameObject camera1;
    public GameObject camera2;
    AudioListener audioListener1;
    AudioListener audioListener2;
    bool switchCamera = false;
    public void IncrementScore()
    {
        MyAudioSources[1].Play();
        points +=1;
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
        MyAudioSources[2].Play();
        score -=5;
        scoreText.text = "Score: " + score;
    }

     public void IncrementHealth()
    {
        if ( currentHealth < 3 )
        {
            MyAudioSources[3].Play();
            currentHealth++;
        }
    }

    public void DecrementHealth()
    {
        MyAudioSources[2].Play();
        currentHealth--;
    }

    void Awake()
    {
        inst =  this;
    }
    // Start is called before the first frame update
    void Start()
    {
        MyAudioSources = GetComponents<AudioSource>();
        audioListener1 = camera1.GetComponent<AudioListener>();
        audioListener2 = camera2.GetComponent<AudioListener>();
        audioListener2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyAudioSources[0].Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            switchCamera = !switchCamera;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            IncrementHealth();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            IncrementScore();
        }
        if (switchCamera)
        {
            camera1.SetActive(false);
            audioListener1.enabled = false;
            camera2.SetActive(true);
            audioListener2.enabled = true;
        }
        else
        {
            camera2.SetActive(false);
            audioListener2.enabled = false;
            camera1.SetActive(true);
            audioListener1.enabled = true;
        }
    }
}
