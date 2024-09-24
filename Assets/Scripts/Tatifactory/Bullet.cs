using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
     public float _speed;
     public int damageBullet;
    private float timeToDestroy = 1f;

    public void Initialize(Flywaight flyweight)
    {
        _speed = flyweight.speed; 
        damageBullet = flyweight.damage;
        Destroy(this.gameObject, timeToDestroy);
    }

}
