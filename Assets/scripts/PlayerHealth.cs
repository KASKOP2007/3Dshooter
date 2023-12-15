using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;

    private bool isDead;

    public GameManagerScript gameManager;
    void Start()
    {
        maxHealth = health;
    }


    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
        }
    }
}
