using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShip : MonoBehaviour
{
    private Rigidbody Bulletrb;
    public Vector3 direction;
    private float timeToDestroy = 5f; 


    public void startMoving()
    {
        Bulletrb.velocity = direction * 5.0f;
        Destroy(this.gameObject, timeToDestroy);
    }

    private void Awake()
    {
        Bulletrb = GetComponent<Rigidbody>();
    }
  
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

}
