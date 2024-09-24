using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject Asteroid; // Prefab del meteorito
    public Transform[] spawnPoints; // Puntos de aparición de meteoritos
    public float spawnInterval = 3f; // Intervalo de tiempo entre spawns


    private void Start()
    {
        StartCoroutine(SpawnMeteorCoroutine());
    }

    private IEnumerator SpawnMeteorCoroutine()
    {
        while (true)
        {
            SpawnMeteor();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnMeteor()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        // Instanciamos el meteorito
        Instantiate(Asteroid, spawnPoint.position, Quaternion.identity);
    }
}
