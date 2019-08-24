using UnityEngine;


[CreateAssetMenu]
public class RuntimeDeck : RuntimeSet<ColorCard>
{
    public int CardsLeft => Items.Count;

    public ColorCard Draw()
    {

        int num = Random.Range(0, Items.Count);

        ColorCard card = Items[num];
        Items.Remove(card);
        // Debug.Log("There are " + Items.Count.ToString() + " cards remaining");
        return card;

    }

    public void Clear()
    {
        Items.Clear();
    }
}
