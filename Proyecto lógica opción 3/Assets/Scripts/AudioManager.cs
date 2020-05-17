 //Librería de unity que permite usar audio en los scripts
 using UnityEngine;
using UnityEngine.Audio;
using System;
public class AudioManager : MonoBehaviour
{
    public Audio[] sonidos;
    public static AudioManager instancia;
    // Start is called before the first frame update
    void Awake()
    {
        //Condicional el cual no permite que se duplique el objeto AudioManager cuando hay carga de una nueva escena
        if(instancia == null)
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
        reproducir("Theme");
    }
    public void reproducir(string nombre)
    {
        Audio a = Array.Find(sonidos,sound => sound.nombre == nombre);
        if (a == null)
            return;
        a.fuente.Play();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) //Condicional que verifica que si se presiona la tecla "esc" el juego se pause
        {
            
        }
    }
}
