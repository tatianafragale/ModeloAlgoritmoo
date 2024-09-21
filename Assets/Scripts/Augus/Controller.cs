using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller: MonoBehaviour
{
    private Model _model;  // Referencia al Model
    private View _view;    // Referencia a la View
    public Weapon weapon;  // Asigna tu arma en el Inspector

    private void Start()
    {
        _model = GetComponent<Model>();
        _view = GetComponent<View>();
    }

    private void Update()
    {
        // Capturamos el input de movimiento horizontal (izquierda y derecha)
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            // Calcula la nueva posición usando el Model
            Vector3 movement = _model.GetMovement(new Vector3(horizontal, 0, 0));
            // Actualiza la posición del jugador usando la View
            _view.UpdatePosition(movement);
        }

        // Si se presiona la barra espaciadora, dispara
        if (Input.GetKeyDown(KeyCode.Space))
        {
            weapon.Shoot();  // Llama al método de disparo del Weapon
        }
    }
}
