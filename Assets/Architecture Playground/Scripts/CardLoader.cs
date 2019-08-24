using UnityEngine;
using System.Collections.Generic;

public class CardLoader : MonoBehaviour
{
    // RuntimeDeck deck;
    public RuntimeDeck Deck;
    public CardSet cardSet;
    public GameObject gameObjectDeck;
    public GameObject board;

    private void Start()
    {
        LoadDeck();
    }

    private void OnMouseDown()
    {
        ClearClones();
        gameObjectDeck.SetActive(true);
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
        Debug.Log(board);
        Debug.Log(board.transform);

        foreach (Transform card in board.transform)
        {
            Debug.Log("destroying " + card);
            GameObject.Destroy(card.gameObject);
        }
    }
}