using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Entity : MonoBehaviour
{
    public int health = 100;  
    public int scoreValue = 50; //Puntos que sueltan al morir  

    //Da�o
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        print(gameObject.name + " recibi� " + damage + " de da�o. Vida restante: " + health);

        if (health <= 0)
        {
            Death();
        }
    }

    
    protected virtual void Death()
    {
        // Disparar el evento de que un enemigo ha sido destruido
        EventManager.TriggerEnemyKilled(scoreValue);
        
        Destroy(gameObject);
    }

}
