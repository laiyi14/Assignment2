using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject LoseScreen;
    public float MaxHealth = 100f;
    public float currentHealth;
    void Start()
    {
        currentHealth = MaxHealth;
    }


    void Update()
    {
        if(currentHealth < 0)
        {
            currentHealth = 0;
            Debug.Log("lose");
            //gameManager.GetComponent<GameManager>().LoseGame();
            LoseScreen.SetActive(true);
            gameManager.PauseGame();
        }
    }

    public void takeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }

    public void Heal(int health)
    {
        currentHealth = currentHealth + health;
    }
}
