using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldJumper : MonoBehaviour
{
    public GameObject currentDeck;

    public void UpdatePosition(Transform pos)
    {
        transform.position = pos.position;
        currentDeck = pos.gameObject;
    }

}
