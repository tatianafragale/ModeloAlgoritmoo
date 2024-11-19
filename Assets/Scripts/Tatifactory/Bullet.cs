using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
     
    private float timeToDestroy = 1f;

    public void Initialize(Flywaight flyweight)
    {
        Destroy(this.gameObject, timeToDestroy);
    }

}
