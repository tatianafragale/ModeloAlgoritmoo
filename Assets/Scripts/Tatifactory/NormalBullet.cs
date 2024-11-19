using UnityEngine;

public class NormalBullet : Bullet
{
    private void Start()
    {
        Initialize(FlywaightPointer.NormalBullet); // Usamos el Flyweight
    }

    void Update()
    {
        transform.position += transform.forward * FlywaightPointer.NormalBullet.speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(FlywaightPointer.NormalBullet.damage);
                Destroy(gameObject);
            }
        }
        else if (other.CompareTag("Big Ship"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(FlywaightPointer.NormalBullet.damage); // MegaBullet hace más daño
                Destroy(gameObject);
            }
        }
    }
}
