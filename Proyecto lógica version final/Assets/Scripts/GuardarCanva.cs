using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarCanva : MonoBehaviour
{
    //Nota: Con este script estaba intentando dejar el menú de ajustes en todas las escenas, y reproducir desde ahí la
    //música, pero no fuincionó. No está ligado a ningún objeto dentro del juego
    public GuardarCanva instancia;
    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
