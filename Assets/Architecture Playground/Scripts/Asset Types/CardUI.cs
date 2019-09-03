using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardUI : MonoBehaviour
{
    public ColorCard card;
    public TextMeshProUGUI colorName;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI attackText;
    public Image background;

    [ExecuteInEditMode]
    private void Start()
    {
        UpdateCard(card);
    }

    [ContextMenu("Reload Card")]
    public void ReloadCard()
    {
        UpdateCard(card);
    }

    public void UpdateCard(ColorCard cardData)
    {
        // Debug.Log("updating card " + cardData);
        // Debug.Log("color:" + cardData.color);
        // HealthText.text = cardData.health;
        // AttackText.text = cardData.attack;
        attackText.text = cardData.num.ToString();
        background.color = cardData.color;
        colorName.SetText(cardData.colorName);
    }

    public void UpdateHealth(int health)
    {
        healthText.text = health.ToString();
    }
}
