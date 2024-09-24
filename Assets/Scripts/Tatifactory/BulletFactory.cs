using UnityEngine.Pool;

public class BulletFactory : Factory<Bullet>
{
    public NormalBullet normalPrefab;
    public MegaBullet megaPrefab;
    ObjectPool<Bullet> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<Bullet>(InstantiatePrefab);
    }

    Bullet InstantiatePrefab()
    {
        return Instantiate(normalPrefab);
    }

    public override Bullet Create(int bulletType = 0)
    {
        if (bulletType == 0)
        {
            return Instantiate(normalPrefab);
        }
        else
        {
            return Instantiate(megaPrefab);
        }
    }
}
