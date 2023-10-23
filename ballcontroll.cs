using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento del personaje

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical) * velocidad * Time.deltaTime;

        // Aplicar el movimiento al objeto del juego
        transform.Translate(movimiento);
    }
}
