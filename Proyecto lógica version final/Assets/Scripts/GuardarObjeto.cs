
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardarObjeto : MonoBehaviour
{
    //Nota: Este script lo iba a utilizar para tratar de que no se reiniciara el sonido en ciertas escenas, pero no
    //pude acomodarlo bien, entonces, no está ligado a ningún objeto del juego
    public static GuardarObjeto instancia=null;
    public int escenaActual;//=SceneManager.GetActiveScene().buildIndex;

    private void Awake()
    {
        /*if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
            return;
        }*/
        /*if (escenaActual != SceneManager.GetActiveScene().buildIndex)
        {
            Destroy(gameObject);
            return;
        }*/
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
        /*if(SceneManager.GetActiveScene().buildIndex != 0)
        {*/
            DontDestroyOnLoad(gameObject);
        
        
    }
}
