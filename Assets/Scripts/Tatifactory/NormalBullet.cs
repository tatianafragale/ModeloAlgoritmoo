using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Llamamos al método TakeDamage en el enemigo, pasándole el daño
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageBullet); // Inflige daño al enemigo

                // Destruir la bala después de impactar
                Destroy(gameObject);
            }

        }
    }
}
