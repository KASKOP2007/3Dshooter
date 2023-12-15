using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
   public void TakeDamage(int Damage)
    {
        health -= Damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
