using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pieza : MonoBehaviour
{
    public int i, j;
    public Vector3 inicial, final;

    public bool cogida, bien;

    public Ficha ficha;

    Ray ray;
    RaycastHit hit;

    void Start()
    {
        inicial = transform.position;
        final = new Vector3 (j-1, 0, i-1);
        bien = true;
        ficha = GetComponent<Ficha>();
    }

    void Update()
    {
        if (cogida)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, 10);
            transform.position = hit.point;
            transform.position = new Vector3(transform.position.x, 0.1f, transform.position.z);
        }
    }

    private void OnMouseDown() //Sustituir por Inputs de control VR
    {
        cogida = true;
        ficha.sostenido = true;
        transform.position += 0.1f * Vector3.up;
    }

    private void OnMouseUp() //Sustituir por Inputs de control VR
    {
        cogida = false;
        ficha.sostenido = false;
        transform.position -= 0.1f * Vector3.up;
        Ganar G = GameObject.Find("Ganar").GetComponent<Ganar>();
        G.Check();
    }
}
