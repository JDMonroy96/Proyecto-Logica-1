using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuInicio : MonoBehaviour
{
   
    public void inicioJuego()
    {
        //Carga la escena del inicio del juego
        SceneManager.LoadScene("Inicio Juego");
    }
}
