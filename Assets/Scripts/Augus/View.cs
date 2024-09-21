using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View: MonoBehaviour
{
    public Transform bulletSpawnPoint;  // Lugar donde se dispara la bala

    // Método para actualizar la posición del jugador
    public void UpdatePosition(Vector3 movement)
    {
        transform.position += movement;
    }
}
