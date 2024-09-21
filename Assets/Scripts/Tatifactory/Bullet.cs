using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float _speed;

    public int damageBullet = 10;

    public void Initialize()
    {
        Debug.Log("Bullet");
    }

}
