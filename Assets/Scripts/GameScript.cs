using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public int money = 0;
    public int rate = 1;

    public TMP_Text money_Text;
    public TMP_Text rate_Text;

    public int currentLvl = 1;
    public int cost = 20;

    public TMP_Text cost_Text;
    public TMP_Text currentLvl_text;

    public Button upgrade_btn;

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        money_Text.text = money.ToString();
        rate_Text.text = "+ " + rate.ToString();
        cost_Text.text = cost.ToString();
        currentLvl_text.text = "LVL  " + currentLvl.ToString();

        if (money < cost)
        {
            upgrade_btn.interactable = false;
        } else upgrade_btn.interactable = true;
    }

    public void Click()
    {
        money += rate;
        UpdateUI();
    }

    public void Upgrade_Click()
    {
        if (money >= cost)
        {
            money -= cost;
            currentLvl++;
            rate++;
            cost = (cost + (cost / 2) * 2);
        }
        UpdateUI();
    }

}
