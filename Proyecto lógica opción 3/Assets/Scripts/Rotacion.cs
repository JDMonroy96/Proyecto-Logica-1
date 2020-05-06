
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    //Variable que hará que el circulo rote 100 grados por segundo, o dado el valor que se le indique.
    public float velocidad_rotacion= 100f;
   
    // Update is called once per frame
    void Update()
    {
        /*Hará una transformación en el objeto usando el metodo Rotate del unity, y los valores harán que no rote ni en x ni en y
         en el eje z rotará según la velocidad dada por el tiempo multiplicado por Time.deltaTime, el cual hará que esta rotación funcione
         independientemente del Frame Rate (Los FPS) del procesador del usuario, y no hayan atrasos.
         */
        transform.Rotate(0f, 0f, velocidad_rotacion * Time.deltaTime);                    
                                
    }
}
