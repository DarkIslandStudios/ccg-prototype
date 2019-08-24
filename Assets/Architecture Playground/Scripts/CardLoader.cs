using UnityEngine;
using System.Collections.Generic;

public class CardLoader : MonoBehaviour
{
    // RuntimeDeck deck;
    public RuntimeDeck Deck;
    public CardSet cardSet;

    private void Start()
    {
        LoadDeck();
    }

    private void OnMouseDown()
    {
        LoadDeck();
    }

    public void LoadDeck()
    {
        Deck.Clear();

        for (int i = 0; i < cardSet.Cards.Count; i++)
        {
            Deck.Add(cardSet.Cards[i]);
        }
    }
}