using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cargaNivel : MonoBehaviour
{ public float tiempo_carga = 1f;
    public Animator transicion;
    public void siguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Carga la siguiente escena (FALTA MODIFICAR Y AJUSTARLO CON TODAS LAS ESCENAS)
        cargaNiveles(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerable cargaNiveles(int indice_nivel)
    {
        //Transición
        transicion.SetTrigger("Inicio"); //Se activa el trigger puesto en el editor para que se active la animación

        yield return new WaitForSeconds(tiempo_carga);//Campo que parará la rutina por un segundo para proceder a cargar el siguiente nivel
        SceneManager.LoadScene(indice_nivel);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            siguienteNivel();
        }
    }
}
