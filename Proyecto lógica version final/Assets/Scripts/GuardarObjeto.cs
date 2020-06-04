
using UnityEngine;

public class GuardarObjeto : MonoBehaviour
{
    public static GuardarObjeto instancia=null;

    private void Awake()
    {
        //Al iniciar, verifica que si no hay un objeto de este tipo, la instancia la toma con referencia a este,
        //pero si hay otro objeto del mismo tipo, lo destruye para que sólo quede uno
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
        //Esta parte, guarda el objeto, para que aparezca en todas las escenas
        DontDestroyOnLoad(gameObject);        
        
    }
}
