using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public Transform[] fichas;
    public Transform[] posicionesPivote;

    public GameObject ganaste;
    public int fichasCorrectas;

    public void Check()
    {
        StartCoroutine(CheckPieza());
    }

    IEnumerator CheckPieza()
    {
        yield return new WaitForSeconds(0.5f);

         int fichasCorrectas = 0;

       
        for (int i = 0; i < fichas.Length; i++)
        {
            float distancia = Vector3.Distance(fichas[i].transform.position, posicionesPivote[i].transform.position);
            if (distancia<=0.01f)
            {

                fichasCorrectas = 0;
            }

           
        }

        if (fichasCorrectas==fichas.Length)
        {   
            Debug.Log("Juego Completado");
            ganaste.SetActive(true);
        }
    }
}

