using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject ObjPuntos;
    public float puntosqueda;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ObjPuntos.GetComponent<Puntos>().SetPuntos(ObjPuntos.GetComponent<Puntos>().GetPuntos() + puntosqueda);
            Destroy(gameObject);
        }
    }




}

internal class Puntos
{
    private float puntos;

    public float GetPuntos()
    {
        return puntos;
    }

    internal void SetPuntos(float value)
    {
        puntos = value;
    }
}