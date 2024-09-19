using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : Entity
{
    public float moveSpeed = 5f;

    void Update()
    {
        //movimiento de la navesita anashe
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }
    
}
