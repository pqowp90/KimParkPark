using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPUI : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    private float maxHP = 10;
    private float currentlyHP = 10;
    void Start()
    {
        slider.value = currentlyHP / maxHP;
    }

    void Update()
    {
        Handle();
    }
    public void FallDamaged()
    {
        currentlyHP -= 3;
        Handle();
    }
    private void Handle()
    {
        slider.value= currentlyHP / maxHP;
    }
    
}
