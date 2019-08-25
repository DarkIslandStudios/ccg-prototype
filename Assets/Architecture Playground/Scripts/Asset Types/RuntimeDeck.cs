using UnityEngine;


[CreateAssetMenu]
public class RuntimeDeck : RuntimeSet<ColorCard>
{
    public int CardsLeft => Cards.Count;

    public ColorCard Draw()
    {
        // Debug.Log("Drawing new Card!");
        int num = Random.Range(0, Cards.Count);

        ColorCard card = Cards[num];
        Cards.Remove(card);
        // Debug.Log("There are " + Cards.Count.ToString() + " cards remaining");
        return card;

    }

    public void Clear()
    {
        Cards.Clear();
    }
}
