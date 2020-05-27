
using UnityEngine;

public class CambiarVolumen : MonoBehaviour
{
    public GameObject audio_manager;//Objeto que tiene el complemento para reproducir el audio

    //Al iniciar, ajusta el volumen con el número que está en la preferencia de "VolumenActual"
    private void Start()
    {
        audio_manager.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumenActual");
    }

    //Método que modifica el volumen del objeto. Está ligado al slider, para que el valor que tenga este, sea
    //el valor del volumen. Además, el número se coloca en la preferencia para poder utilizarse más adelante
    public void cambiarVolumen(float volumen)
    {
        audio_manager.GetComponent<AudioSource>().volume = volumen;
        PlayerPrefs.SetFloat("VolumenActual", volumen);
    }



}
