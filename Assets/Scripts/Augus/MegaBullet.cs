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
                enemy.TakeDamage(damageBullet * 2); // MegaBullet hace más daño
                Destroy(gameObject);
            }
        }
        else if (other.CompareTag("Big Ship"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageBullet * 2); // MegaBullet hace más daño
                Destroy(gameObject);
            }
        }
    }
}
