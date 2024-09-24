using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    private Model _model;  
    private View _view;    
    public Weapon weapon;  

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

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weapon.Shoot();
        }
    }
}
