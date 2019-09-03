using UnityEngine;

public class FieldDeck : MonoBehaviour
{
    public RuntimeCardStack deck;
    public ColorCard initialCard;

    private void Start()
    {
        // Debug.Log("Initializing Deck with " + initialCard);
        deck.AddToTopOfDeck(initialCard);
    }

    public void MoveToDeck(RuntimeCardStack newDeck)
    {
        Debug.Log("Moving To Deck " + newDeck);
        ColorCard card = deck.DrawFirstCard();
        newDeck.AddToTopOfDeck(card);
    }

}