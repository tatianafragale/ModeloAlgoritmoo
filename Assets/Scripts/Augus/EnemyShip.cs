using UnityEngine;

public class EnemyShip : Entity
{
    public float moveSpeed = 5f;
    public float lifetime = 10f; // Tiempo que el meteorito esta vivo

    private void Start()
    {        
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        //movimiento del meteorito anashe
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) //Choca con el player y se destuye
    {
        
        if (other.CompareTag("Player")) 
        {
            Destroy(gameObject);
        }
    }

}
