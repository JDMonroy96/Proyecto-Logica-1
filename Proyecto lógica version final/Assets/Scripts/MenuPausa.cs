using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{
    //Variable booleana que será usada en otros scripts para verificar el estado del juego (si está pausado o no)
    public static bool juego_pausado = false;
    public GameObject menu_pausa_UI; //objeto que simboliza el menu de pausa

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Condicional que verifica que si se presiona la tecla "esc" el juego se pause
        {
            if (juego_pausado)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }
    }
    //Metodo que reanuda el juego
    public void Reanudar()
    {
        juego_pausado = false;
        menu_pausa_UI.SetActive(false); //desactiva el menú de pausa
        Time.timeScale = 1f;
    }
    //Metodo el cual Congela el juego 
    void Pausar()
    {
        menu_pausa_UI.SetActive(true); //activa el menú de pausa
        Time.timeScale = 0f;
        juego_pausado = true; //Cambio en el valor del parametro que provoca que el juego pause.
    }

    public void cargaMenu()
    {
        Time.timeScale = 1f;//provoca que la aplicación no se quede pausada después de cargar la escena del menú
        SceneManager.LoadScene("Inicio Juego");
    }

    public void salirJuego()
    {
        Debug.Log("Saliendo");
        Application.Quit(); //cierra el juego, en el editor no se ejecuta.
    }

}
