using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigShip : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform firePoint;
    public float fireRate = 2.0f; //Tiempo entre los disparos


    private Transform player;
    private float nextFireTime;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //Busca al jugador
        nextFireTime = Time.time;
    }


    void Update()
    {
        
        if(Time.time >= nextFireTime)
        {
            ShootAtPlayer();
            nextFireTime = Time.time;
        }


    }

    void ShootAtPlayer() //Esta funcion crea la bala y la dirige hacia la posicion del jugador
    {
        if(player != null)
        {
            GameObject bullet = Instantiate(bulletprefab, firePoint.position, Quaternion.identity);
            Vector3 direction = (player.position - firePoint.position).normalized; // Calcula la direccion hacia el jugador
            bullet.GetComponent<Rigidbody>().velocity = direction * 5.0f;
        }

    }



}
