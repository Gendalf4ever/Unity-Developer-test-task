using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float fill;
    void Start()
    {
        fill = 1f; //100% Fill
    }

  
    void Update()
    {
        healthBar.fillAmount = fill;
    }
}
