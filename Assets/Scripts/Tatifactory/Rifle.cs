using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    public Transform bulletSpawnPoint; //Donde sale la bala del player (el nuevo transform)


    public override void Shoot()
    {
        Bullet newBullet = _factory.Create(); //Crea una nueva bala

        // Establece la posición y dirección de la bala
        newBullet.transform.position = bulletSpawnPoint.position; //Usa el punto de disparo
        newBullet.transform.rotation = bulletSpawnPoint.rotation; //Usa la rotación del punto de disparo

        EventManager.BulletFired(); //El evento de disparo de bala

    }
}