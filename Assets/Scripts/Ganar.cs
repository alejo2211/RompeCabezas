using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public Transform pieza1;
    public Transform pieza2;
    public Transform pieza3;
    public Transform pieza4;
    public Transform pieza5;
    public Transform pieza6;
    public Transform pieza7;
    public Transform pieza8;
    public Transform pieza9;

    public GameObject ganaste;

    public void Check()
    {
        StartCoroutine(CheckPieza());
    }

    IEnumerator CheckPieza()
    {
        yield return new WaitForSeconds(0.5f);

        if (pieza1.transform.localPosition == new Vector3(-0.86f, 0, 1))
        {
            Debug.Log("pieza1 concuerdo");

            if (pieza2.transform.localPosition == new Vector3(-0.152f, 0, 1.106f))
            {
                Debug.Log("pieza2 concuerdo");

                if (pieza3.transform.localPosition == new Vector3(0.58f, 0, 1.055f))
                {
                    Debug.Log("pieza2 concuerdo");

                    if (pieza4.transform.localPosition == new Vector3(-0.9999999f, 0, 0.263f))
                    {
                        Debug.Log("pieza4 concuerdo");

                        if (pieza5.transform.localPosition == new Vector3(-0.15f, 0, 0.289f))
                        {
                            Debug.Log("pieza5 concuerdo");

                            if (pieza6.transform.localPosition == new Vector3(0.705f, 0, 0.325f))
                            {
                                Debug.Log("pieza6 concuerdo");

                                if (pieza7.transform.localPosition == new Vector3(-0.9029999f, 0, -0.486f))
                                {
                                    Debug.Log("pieza7 concuerdo");

                                    if (pieza8.transform.localPosition == new Vector3(-0.112f, 0, -0.515f))
                                    {
                                        Debug.Log("pieza8 concuerdo");

                                        if (pieza9.transform.localPosition == new Vector3(0.6420001f, 0, -0.475f))
                                        {
                                            Debug.Log("Juego Completado");

                                            ganaste.SetActive(true);
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }

        }
    }
}
