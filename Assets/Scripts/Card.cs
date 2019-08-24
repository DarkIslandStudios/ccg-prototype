using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public ScriptableCard cardTemplate;
    public int manaCost;
    public int attack;
    public int health;

    public TextMesh manaText;
    public TextMesh attackText;
    public TextMesh healthText;
    // Start is called before the first frame update
    void Start()
    {
        manaText.text = cardTemplate.mana.ToString();
        healthText.text = cardTemplate.health.ToString();
        attackText.text = cardTemplate.attack.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Play();
    }

    void Play() {
        Debug.Log("play for: " + manaCost.ToString() +  " mana");
    }

    void Attack() {
        Debug.Log("attack for: " + attack.ToString());
    }

    void Health() {
        Debug.Log("health remaining: " + health.ToString());
    }
}
