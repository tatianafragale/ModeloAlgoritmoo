using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float _speed;


    public void Initialize()
    {
        Debug.Log("Bullet");
    }

}
