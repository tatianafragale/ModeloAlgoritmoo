using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    
    public float spawnInterval = 5.0f; //Tiempo entre spawns
    public Transform[] spawnPoints; //Index de puntos de spawn para la nave
    private Transform ship;

    private void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Big Ship").transform; 
        
    }

    private void Update()
    {
        spawnInterval -= Time.deltaTime;

        if(spawnInterval <= 0)
        {
            ShipTp();
            spawnInterval = 5;
            
        }


    }

    private void ShipTp()
    {
        int tpShip = Random.Range(0, spawnPoints.Length);
        ship.transform.position = spawnPoints[tpShip].position;



    }
    

}
