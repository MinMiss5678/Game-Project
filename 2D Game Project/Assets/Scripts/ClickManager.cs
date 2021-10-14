using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClickerLastTime = new List<float>();
    public int autoClickerPrice;

    public TextMeshProUGUI quantityText;

    private void Update()
    {
        for (int i = 0; i < autoClickerLastTime.Count; i++)
        {
            if (Time.time - autoClickerLastTime[i] >= 1.0f)
            {
                autoClickerLastTime[i] = Time.time;
                EnemyManger.instance.curEnemy.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        if(Gamemanager.instance.gold >= autoClickerPrice)
        {
            Gamemanager.instance.TakeGold(autoClickerPrice);
            autoClickerLastTime.Add(Time.time);

            quantityText.text = "x" + autoClickerLastTime.Count.ToString();
        }
    }
}
