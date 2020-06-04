using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarJuego : MonoBehaviour
{
    public void EmpezarJuego()
    {
        //Carga la siguiente escena
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    //Carga la escena de créditos
    public void creditosJuego()
    {
        SceneManager.LoadScene("Final");
    }
}
