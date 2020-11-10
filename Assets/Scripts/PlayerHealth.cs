using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameManager gameManager;
    public Image fillImage;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }
        if (gameManager.currentHealth == 1)
        {
            fillImage.color = Color.red;
        }
        float fillValue = (gameManager.currentHealth/ gameManager.maxHealth);
        slider.value = fillValue;
    }
}
