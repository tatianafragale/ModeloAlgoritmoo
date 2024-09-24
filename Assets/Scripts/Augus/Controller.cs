using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    private Model _model;  
    private View _view;    
    public Weapon weapon;
    public float delayBala = 0.5f; // Tiempo entre disparos en segundos
    private float nextFireTime = 0f; // Momento en que se puede disparar nuevamente


    private void Start()
    {
        _model = GetComponent<Model>();
        _view = GetComponent<View>();

    }

    private void Update()
    {
        //input de movimiento horizontal (izquierda y derecha)
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            // Calcula la nueva posición usando el Model
            Vector3 movement = _model.GetMovement(new Vector3(horizontal, 0, 0));
            // Actualiza la posición del jugador usando la View
            _view.UpdatePosition(movement);
        }
        else
        {
            _view.shipBody.velocity = Vector3.zero;
        }

       
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            weapon.Shoot();
            nextFireTime = Time.time + delayBala; // Actualiza el tiempo del próximo disparo
        }


    }
}
