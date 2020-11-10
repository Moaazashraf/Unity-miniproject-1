using UnityEngine;

public class Player : MonoBehaviour
{
    public float timer = 0.0f;
    Renderer renderer;
    public Material red;
    public Material yellow;
    public Material blue;
    


    // Color red = new Color( 255.0f, 0.0f, 0.0f, 1.0f );
    // Color yellow = new Color( 255.0f, 255.0f, 0.0f, 1.0f );
    // Color blue = new Color( 0.0f, 0.0f, 255.0f, 1.0f );
    // Start is called before the first frame update
    void Start()
    {
        renderer = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 15.0f)//change the float value here to change how long it takes to switch.
        {
            Material[] ranColor = {red, yellow, blue};
            int colorIndex = Random.Range(0, 3);
            renderer.material = ranColor[colorIndex];
            timer = 0;
        }
    }
}
