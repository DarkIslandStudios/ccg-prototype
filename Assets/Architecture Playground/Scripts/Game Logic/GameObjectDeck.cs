using UnityEngine;

public class GameObjectDeck : MonoBehaviour
{
    public RuntimeDeck deck;
    public PlayerHand playerHand;
    public GameObject deckUI;
    // public GameObject prefab;
    // public Transform board;

    private void OnMouseDown()
    {
        // Draw();
    }

    public void Draw()
    {
        if (deck.CardsLeft > 0)
        {
            ColorCard newCard = deck.Draw();
            playerHand.AddNewCard(newCard);
            // GameObject p = Instantiate(prefab, new Vector3(-9 + 3 * (5 - deck.CardsLeft), 0, 0), Quaternion.identity);

            // p.GetComponent<GameObjectCard>().UpdateCard(newCard);
            // p.transform.SetParent(board);
            // UpdateCard(newCard);
            Debug.Log(deck.CardsLeft.ToString() + " cards left in the deck!");
            if (deck.CardsLeft == 0)
            {
                DisableDeck();
            }
        }
    }

    public void DisableDeck()
    {
        deckUI.SetActive(false);
    }

    public void EnableDeck()
    {
        deckUI.SetActive(true);
    }

    private void OnDestroy()
    {
        deck.Clear();
    }
}