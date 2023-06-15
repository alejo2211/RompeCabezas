using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ficha : MonoBehaviour
{
    public Transform snapPoint;
    public bool sostenido;

    void Update()
    {
        if (snapPoint != null && !sostenido)
        {
            transform.position = snapPoint.position;
            transform.rotation = snapPoint.rotation;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Punto"))
        {
            snapPoint = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Punto"))
        {
            snapPoint = null;
        }
    }

    public void Agarrar()
    {
        
        sostenido = true;
    }

    public void Soltar()
    {
        sostenido = false;
        
        Ganar.singleton.Check();
    }
}
