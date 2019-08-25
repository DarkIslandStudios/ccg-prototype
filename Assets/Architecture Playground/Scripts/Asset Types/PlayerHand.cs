using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public RuntimeDeck Cards;
    public GameObject handPanel;
    public GameObject field;
    public GameObject cardPrefab;

    public void AddNewCard(ColorCard card)
    {
        Cards.Add(card);
        // GameObject cardUI = Instantiate(cardPrefab);
        GameObject cardUI = Instantiate(cardPrefab, handPanel.transform);
        CardUI cui = cardUI.GetComponent<CardUI>();

        // Debug.Log(card);
        // Debug.Log(cardUI);
        // Debug.Log(cui);

        cui.UpdateCard(card);
    }

    public void PlayCard(ColorCard card)
    {
        Cards.Remove(card);
    }
}
