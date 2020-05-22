 //Librería de unity que permite usar audio en los scripts
 using UnityEngine;
using UnityEngine.Audio;
using System;
public class AudioManager : MonoBehaviour
{
    public Audio[] sonidos;
    public static AudioManager instancia;
    private bool mute;
    // Start is called before the first frame update
    void Awake()
    {
      
        //Condicional el cual no permite que se duplique el objeto AudioManager cuando hay carga de una nueva escena
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);//metodo que no destruye el objeto AudioManager cada que se carga una nueva escena
        foreach (Audio a in sonidos)
        {
            a.fuente = gameObject.AddComponent<AudioSource>();
            a.fuente.clip = a.clip;
            a.fuente.volume = a.volumen;
            a.fuente.pitch = a.pitch;
            a.fuente.loop = a.bucle;
        }
        
    }

    private void Start()
    {
        mute = PlayerPrefs.GetInt("MUTEADO") == 1; //Toma el estado respecto a la variable mute que el usuario dejó asignado
        AudioListener.pause = mute;
        reproducir("Theme");  
           
    }
    public void reproducir(string nombre)
    {
        
        Audio a = Array.Find(sonidos,sound => sound.nombre == nombre);
        if (a == null)
        
            return;
            a.fuente.Play();       


    }

    public void PresionarMute()
    {
        mute = !mute;
        AudioListener.pause = mute;
        PlayerPrefs.SetInt("MUTEADO", mute ? 1 : 0); //Muestra el estado que el usuario ya tenía asignado por defecto
    }

    void Update()
    {
       // mute = PlayerPrefs.GetInt("MUTEADO") == 1; //Toma el estado respecto a la variable mute que el usuario dejó asignado
        if (Input.GetKeyDown(KeyCode.M)) //Condicional que verifica que si se presiona la tecla "esc" el juego se pause
        {
            PresionarMute();
        }
    }
}
