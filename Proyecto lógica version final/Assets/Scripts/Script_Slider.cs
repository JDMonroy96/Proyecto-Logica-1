using UnityEngine.UI;
using UnityEngine;

public class Script_Slider : MonoBehaviour
{
    public Slider barra_desplazamiento;//Slider que ajusta el volumen del juego

    // Al inicio ajusta el valor del Slider para que coincida con la preferencia "VolumenActual"
    void Start()
    {
        barra_desplazamiento.value = PlayerPrefs.GetFloat("VolumenActual");
    }

    public void ajustarSlider()
    {
        barra_desplazamiento.value = PlayerPrefs.GetFloat("VolumenActual");
    }

}
