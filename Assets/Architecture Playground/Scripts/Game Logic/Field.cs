using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public CardField player;
    public CardField enemey;

    public void PlayerAttack()
    {
        Debug.Log("attacking enemy");
        player.Attack(enemey);
    }
    public void EnemyAttack()
    {
        Debug.Log("attacking player");
        enemey.Attack(player);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
