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
            //Llamamos al m�todo TakeDamage en el enemigo, pas�ndole el da�o
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageBullet); // Inflige da�o al enemigo

                // Destruir la bala despu�s de impactar
                Destroy(gameObject);
            }

        }
    }
}
