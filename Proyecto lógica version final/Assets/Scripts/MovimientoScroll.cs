using UnityEngine.UI;
using UnityEngine;
using System;

public class MovimientoScroll : MonoBehaviour
{
    //float valor_volumen = AudioManager.fuente.volume;
    //public float nivel_volumen; BB
    //public Slider barra_desplazamiento; AAA
    public GameObject audio_manager;
    //public static GameObject audio_manager2; BB

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("VolumenActual"))
        {
            PlayerPrefs.SetFloat("VolumenActual", 0.5f);
        }
        //DontDestroyOnLoad(barra_desplazamiento);
        //DontDestroyOnLoad(audio_manager);
        //audio_manager.GetComponent<AudioSource>().volume = nivelVolumen.volumen;
        //audio_manager2 = audio_manager;
    }

    // Start is called before the first frame update
    void Start()
    {
        //audio_manager.GetComponent<AudioSource>().volume = nivelVolumen.volumen; BB
        //audio_manager.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumenActual"); CC//BB

        //audio_manager2 = audio_manager; BB
        //nivel_volumen = AudioManager.fuente.volume;
        //nivel_volumen = audio_manager.GetComponent<AudioSource>().volume; BB
        //barra_desplazamiento.value = nivel_volumen; AAA
        //nivelVolumen.volumen = nivel_volumen; BB
        //PlayerPrefs.SetFloat("VolumenActual", nivel_volumen); BB
    }

    // Update is called once per frame
    void Update()
    {
        /*if (MenuAjustes.ajustes_activos)
        {
            audio_manager.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("VolumenActual");
            /*nivel_volumen = PlayerPrefs.GetFloat("VolumenActual"); //AAA
            audio_manager.GetComponent<AudioSource>().volume = nivel_volumen;*/ //BB
            /*if(nivel_volumen != audio_manager.GetComponent<AudioSource>().volume)
            {
                nivel_volumen = audio_manager.GetComponent<AudioSource>().volume;
            }* /
            //audio_manager2 = audio_manager; BB
        }*///CC
    }

}
