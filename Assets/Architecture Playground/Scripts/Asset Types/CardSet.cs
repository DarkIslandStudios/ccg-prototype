using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Card Set", menuName = "Card Set")]
public class CardSet : ScriptableObject
{
    public List<ColorCard> Cards = new List<ColorCard>();
}