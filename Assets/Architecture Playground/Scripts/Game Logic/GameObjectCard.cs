using UnityEngine;

public class GameObjectCard : MonoBehaviour
{

    public ColorCard cardData;
    public GameObject cardCube;
    public TextMesh cardName;


    public void UpdateCard(ColorCard newCard)
    {
        cardData = newCard;
        // Set new cards color
        Renderer r = cardCube.GetComponent<Renderer>();
        r.material.SetColor("_Color", cardData.color);

        // Set new cards name
        cardName.text = cardData.name.ToString();
    }

}
