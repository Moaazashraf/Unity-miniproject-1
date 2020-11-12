using UnityEngine;

public class Player : MonoBehaviour
{
    public float timer = 0.0f;
    Renderer renderer;
    public Material red;
    public Material yellow;
    public Material blue;
    AudioSource m_MyAudioSource;

    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15.0f  || Input.GetKeyDown(KeyCode.R))//change the float value here to change how long it takes to switch.
        {
            Material[] ranColor = {red, yellow, blue};
            int colorIndex = Random.Range(0, 3);
            renderer.material = ranColor[colorIndex];
            m_MyAudioSource.Play();
            timer = 0;
        }
    }
}
