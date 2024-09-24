using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
     public float _speed;
     public int damageBullet;

    public void Initialize(Flywaight flyweight)
    {
        _speed = flyweight.speed; 
        damageBullet = flyweight.damage;
    }

}
