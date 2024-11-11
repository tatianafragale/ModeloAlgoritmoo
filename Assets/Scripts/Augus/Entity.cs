using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Entity : MonoBehaviour
{
    public int health = 100;  
    public int scoreValue = 50; //Puntos que sueltan al morir  
    public bool respawnBigShip = false;
    public event Action isDead; // Envia el mensaje de la accion de morir

    //Daño
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        print(gameObject.name + " recibió " + damage + " de daño. Vida restante: " + health);

        if (health <= 0)
        {
            Death();
            ScreenManager screenManager = FindObjectOfType<ScreenManager>();
            if (screenManager != null)
            {
                screenManager.Victory();
            }
        }
    }

    
    protected virtual void Death()
    {
        // Disparar el evento de que un enemigo ha sido destruido
        EventManager.TriggerEnemyKilled(scoreValue);
        isDead.Invoke();
        Destroy(gameObject);
    }




}
