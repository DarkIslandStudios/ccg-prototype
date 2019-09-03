using UnityEngine;

[CreateAssetMenu(fileName = "Runtime Card Stack", menuName = "Runtime Card Set", order = 0)]
public class RuntimeCardStack : RuntimeStack<ColorCard>
{
    public void AddToTopOfDeck(ColorCard card)
    {
        Debug.Log(card + " being added to top of deck");
        AddItem(card);
    }

    public ColorCard DrawFirstCard()
    {
        return PopItem();
    }
}