using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerr : MonoBehaviour
{
    public Weapon weapon;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            weapon.Shoot();
    }
}

//se escapo una r aca dea