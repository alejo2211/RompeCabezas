using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonManager : MonoBehaviour
{
 public void jugarDeNuevo()
    {
        SceneManager.LoadScene("RompeCabezas"); // Carga la escena principal nuevamente
    }
}
