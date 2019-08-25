using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardUI : MonoBehaviour
{
    public TextMeshProUGUI colorName;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI attackText;
    public Image background;

    public void UpdateCard(ColorCard cardData)
    {
        // Debug.Log("updating card " + cardData);
        // Debug.Log("color:" + cardData.color);
        // HealthText.text = cardData.health;
        // AttackText.text = cardData.attack;
        background.color = cardData.color;
        colorName.SetText(cardData.colorName);
    }
}
