using UnityEngine;

public class AjustarVolumenInicial : MonoBehaviour
{
    public GameObject audio_manager;

    private void Awake()
    {
        //Si al inicio, no hay una preferencia de "VolumenActual", se inicia una con el valor de 0.5
        if (!PlayerPrefs.HasKey("VolumenActual"))
        {
            PlayerPrefs.SetFloat("VolumenActual", 0.5f);
        }
        //Se ajusta el volumen del audio al volumen que está en "VolumenActual" al iniciar la escena
        audio_manager.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumenActual");
        
    }
}
