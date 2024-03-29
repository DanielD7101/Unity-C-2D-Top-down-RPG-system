using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfFullHeart;
    public Sprite emptyHeart;
    public FloatValue heartContainers;
    public FloatValue playerCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        InitialiseHearts();
    }

    public void InitialiseHearts()
    {
        for(int i = 0; i < heartContainers.runtimeValue; i++)
        {
            hearts[i].gameObject.SetActive(true);
            hearts[i].sprite = fullHeart;
        }
    }

    public void UpdateHearts()
    {
        InitialiseHearts();
        float tempHealth = playerCurrentHealth.runtimeValue / 2;
        for(int i = 0; i < heartContainers.runtimeValue; i++)
        {
            if(i <= tempHealth - 1)
            {
                // Full heart
                hearts[i].sprite = fullHeart;
            }
            else if(i >= tempHealth)
            {
                // Empty heart
                hearts[i].sprite = emptyHeart;
            }
            else
            {
                // Half-full heart
                hearts[i].sprite = halfFullHeart;
            }
        }
    }
}
