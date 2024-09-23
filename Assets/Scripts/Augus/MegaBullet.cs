using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaBullet : Bullet
{
    private void Start()
    {
        Initialize(FlywaightPointer.MegaBullet); // Usamos el Flyweight
    }

    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageBullet * 2); // MegaBullet doble de daño
                Destroy(gameObject);
            }
        }
    }
}
