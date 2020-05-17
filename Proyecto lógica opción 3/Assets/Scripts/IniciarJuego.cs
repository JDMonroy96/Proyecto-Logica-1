using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    public void EmpezarJuego()
    {
        //Carga la siguiente escena (FALTA MODIFICAR Y AJUSTARLO CON TODAS LAS ESCENAS)
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void creditosJuego()
    {
        SceneManager.LoadScene("Final");
    }
}
