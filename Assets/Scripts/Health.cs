using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider playerSlider3D;
    Slider playerSlider2D;

    public int health;
    
    void Start()
    {
        playerSlider2D = GetComponent<Slider>();
        playerSlider2D.maxValue = health;
        playerSlider3D.maxValue = health;
    }

    
    void Update()
    {
        playerSlider2D.value = health;
        playerSlider3D.value = playerSlider2D.value;
    }
}
