using UnityEngine.Audio;
using UnityEngine;
//hace posible que se vean los parametros públicos en el editor
[System.Serializable]
public class Audio //Clase personalizada la cual tendrá los parametros para configurar desde el editor el sonido.
{
    public string nombre;
    public AudioClip clip;
    [Range(0f,1f)]
    public float volumen;
    [Range(0f,1f)]
    public float pitch;
    public bool bucle;
    public AudioSource fuente;
}
