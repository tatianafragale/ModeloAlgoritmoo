using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet : Bullet
{
    void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
