using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View: MonoBehaviour
{
    public Transform bulletSpawnPoint;  // Lugar donde se dispara la bala
    public Rigidbody shipBody;

    public void Start()
    {
        shipBody = GetComponent<Rigidbody>();
        
    }


    // Método para actualizar la posición del jugador
    public void UpdatePosition(Vector3 movement)
    {  
        shipBody.velocity = movement;

    }





}
