using UnityEngine;
using System.Collections.Generic;

public class CardLoader : MonoBehaviour
{
    // RuntimeDeck deck;
    public RuntimeDeck Deck;
    public CardSet cardSet;
    public GameObjectDeck gameObjectDeck;
    public GameObject handPanel;

    private void Start()
    {
        LoadDeck();
    }

    private void OnMouseDown()
    {
        ClearClones();
        gameObjectDeck.EnableDeck();
        LoadDeck();
    }

    public void ResetDeck()
    {
        ClearClones();
        gameObjectDeck.EnableDeck();
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

    public void ClearClones()
    {
        Debug.Log("clearing clones...");

        foreach (Transform card in handPanel.transform)
        {
            Debug.Log("destroying " + card);
            GameObject.Destroy(card.gameObject);
        }
    }
}