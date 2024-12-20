using UnityEngine;

public class MegaBullet : Bullet
{
    private void Start()
    {
        Initialize(FlywaightPointer.MegaBullet); // Usamos el Flyweight
    }

    void Update()
    {
        transform.position += transform.forward * FlywaightPointer.MegaBullet.speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(FlywaightPointer.MegaBullet.damage * 2); // MegaBullet hace m�s da�o
                Destroy(gameObject);
            }
        }
        else if (other.CompareTag("Big Ship"))
        {
            Entity enemy = other.GetComponent<Entity>();
            if (enemy != null)
            {
                enemy.TakeDamage(FlywaightPointer.MegaBullet.damage * 2); // MegaBullet hace m�s da�o
                Destroy(gameObject);
            }
        }
    }
}
