using UnityEngine;

public class BigShip : Entity
{
    public GameObject bulletprefab;
    public Transform firePoint;
    public float fireRate = 2.0f; //Tiempo entre los disparos
    public float respawnTime = 5f; //Tiempo de respawn de la nave

    private Transform player;
    [SerializeField] private float nextFireTime = 0.5f;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //Busca al jugador
        isDead += deadRespawn; //Cuando llegue el mensaje de "mori", se llama a la funcion de respawn
        
    }


    void Update()
    {
        nextFireTime -= Time.deltaTime;

        if(nextFireTime <= 0)
        {
            ShootAtPlayer();
            nextFireTime = 0.5f;

        }
        


    }

    void ShootAtPlayer() //Esta funcion crea la bala y la dirige hacia la posicion del jugador
    {
        if(player != null)
        {
            BulletShip bullet = Instantiate(bulletprefab, firePoint.position, Quaternion.identity).GetComponent<BulletShip>();
            Vector3 direction = (player.position - firePoint.position).normalized; // Calcula la direccion hacia el jugador
            bullet.direction = direction;
            bullet.startMoving();
        }

    }

    public void deadRespawn()
    {
        gameObject.SetActive(false);
        Invoke(nameof(Respawn), respawnTime);



    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        health = 100;




    }




}
