using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    public Transform bulletSpawnPoint;
    private int shotsFired = 0;

    public override void Shoot()
    {
        shotsFired++;

        Bullet newBullet;

        if (shotsFired >= 10)
        {
            newBullet = _factory.Create(1); // MegaBullet
            shotsFired = 0; // Reset the count
        }
        else
        {
            newBullet = _factory.Create(0); // NormalBullet
        }

        // Set bullet's position and rotation
        newBullet.transform.position = bulletSpawnPoint.position;
        newBullet.transform.rotation = bulletSpawnPoint.rotation;

        EventManager.BulletFired();
    }
}