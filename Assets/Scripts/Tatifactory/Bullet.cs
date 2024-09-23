using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] public float _speed = 200;
    [SerializeField] public int damageBullet = 10;

    public void Initialize(Flywaight flyweight)
    {
        _speed = flyweight.speed;
    }

}
