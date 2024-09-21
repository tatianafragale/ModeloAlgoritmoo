using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void BulletFiredHandler();
    public static event BulletFiredHandler OnBulletFired;

    public delegate void EnemyHitHandler();
    public static event EnemyHitHandler OnEnemyHit;

    //Delegado para el evento de enemigo destruido
    public delegate void EnemyKilledHandler(int scoreValue);
    public static event EnemyKilledHandler OnEnemyKilled;

    //Para el evento cuando una bala es disparada
    public static void BulletFired()
    {
        if (OnBulletFired != null)
        {
            OnBulletFired.Invoke();
            print("DISPARÉ");
        }
    }

    //Dispara el evento cuando un enemigo es impactado por la bala/balas
    public static void EnemyHit()
    {
        if (OnEnemyHit != null)
        {
            OnEnemyHit.Invoke();
            print("HIT ENEMY");
        }
    }

    public static void TriggerEnemyKilled(int scoreValue)
    {
        OnEnemyKilled?.Invoke(scoreValue);
        Debug.Log("ENEMY KILLED, PUNTOS: " + scoreValue);
    }
}
