using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardField : MonoBehaviour
{

    public ColorCard card;
    public CardUI cardUI;
    public int health;
    public int attack;

    public void Attack(CardField enemy)
    {
        Debug.Log("attacking " + enemy + " for " + attack + " damage");
        enemy.RecieveDamage(attack);
    }

    public void RecieveDamage(int damage)
    {
        Debug.Log("attacked " + " for " + damage + " damage");
        health -= damage;
        cardUI.UpdateHealth(health);
    }

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        attack = card.num;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
