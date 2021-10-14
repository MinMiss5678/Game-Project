using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public int gold;
    public static Gamemanager instance;

    public Sprite[] backgrounds;
    private int curBackground;
    private int enemiesUntilBackgroundChange = 5;

    public Image backgroundImage;

    public TextMeshProUGUI goldText;

    void Awake()
    {
        instance = this;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = "Gold:" + gold.ToString();
    }

    public void TakeGold(int amount)
    {
        gold -= amount;
        goldText.text = "Gold:" + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUntilBackgroundChange--;

        if(enemiesUntilBackgroundChange == 0)
        {
            curBackground++;
            enemiesUntilBackgroundChange = 5;

            if(curBackground == backgrounds.Length)
            {
                curBackground = 0;
            }

            backgroundImage.sprite = backgrounds[curBackground];
        }
    }
}
