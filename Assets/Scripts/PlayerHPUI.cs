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
    public void PlayerDead(GameObject values)
    {
        if(currentlyHP<=0)
        {
            Destroy(values);
            Time.timeScale = 0;
        }
    }
    private void Handle()
    {
        slider.value= currentlyHP / maxHP;
    }
    
}
