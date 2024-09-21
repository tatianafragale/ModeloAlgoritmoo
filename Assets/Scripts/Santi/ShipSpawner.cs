using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 5.0f; //Tiempo entre spawns
    public Transform[] spawnPoints; //Index de puntos de spawn para la nave

    private float nextSpawnTime;


    private void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnInterval;

        }
    }


    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); //Elige un punto de spawn aleatorio
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity); //Crea la nave en el punto seleccionado
    }


}
