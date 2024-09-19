using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BulletFactory : Factory<Bullet>
{
    public Bullet prefab;
    ObjectPool<Bullet> _pool;


    private void Awake()
    {
        _pool = new ObjectPool<Bullet>(InstantiatePrefab);
    }

    Bullet InstantiatePrefab()
    {
        return Instantiate(prefab);
    }
    public override Bullet Create()
    {
        return Instantiate(prefab);
    }
}
