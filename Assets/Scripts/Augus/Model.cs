using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model: MonoBehaviour
{
    public float speed = 5f;  // La velocidad del movimiento

    // M�todo para obtener la posici�n del jugador
    public Vector3 GetMovement(Vector3 direction)
    {
        return direction * speed * 2000 * Time.deltaTime;
    }
}
