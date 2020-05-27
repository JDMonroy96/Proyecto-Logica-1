
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Script_Jugador : MonoBehaviour
{
    public float fuerza_salto = 10f;
    public Rigidbody2D rb;
    public string color_actual;
    public int numero_color = -1; //esta variable asigna un número dependiendo del color actual del jugador. Empieza en -1
                                    //para evitar problemas con el método asignarColor
    public SpriteRenderer sr;
    public Color amarillo;
    public Color cyan;
    public Color morado;
    public Color magenta;
    public bool cero_clicks = true;
    public int numero_escena;
    public int nivel_completado;
    public bool meta_alcanzada;

    private void Start()
    {
        asignarColor();
        rb.isKinematic = true;//este método, impide que el jugador sea afectado por fuerzas al inicio del 
                              //juego (excepto gravedad)
        rb.gravityScale = 0;//se pone la gravedad en 0 para que no caiga al inicio del nivel

        //Se establece el nivel como no terminado
        meta_alcanzada = false;

        //se asigna a una variable el número de la escena
        numero_escena = SceneManager.GetActiveScene().buildIndex;
        //se asigna el número del nivel completado, con referencia a las opciones guardadas
        nivel_completado = PlayerPrefs.GetInt("NivelCompletado")-1;

    }

    //Metodo que actuará cada que haya una colisión
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //condicional para cuando el jugador termine el nivel, y no se resetee en caso de chocar con un obstáculo
        if (!meta_alcanzada)
        {
            //Condicional que indica si al haber contacto con el objeto de intercambio de color, asigne un color aleatorio
            if (collision.tag == "intercambio")
            {
                asignarColor();
                Destroy(collision.gameObject);
                return;
            }
            //Condicional para cuando el jugador toque la meta
            else if (collision.tag == "Meta")
            {
                meta_alcanzada = true;
                if (numero_escena > nivel_completado)
                {
                    PlayerPrefs.SetInt("NivelCompletado", numero_escena);
                }
                //Se invoca el método que muestra el menú de niveles luego de un segundo
                Invoke("CargarMenu", 1f);
            }
            //Condicional diseñado para cuando el jugador toque un obstáculo con color diferente al suyo
            else if (collision.tag != color_actual)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
    }

    //Metodo que le asignará un color aleatorio al jugador al iniciar el juego
    private void asignarColor()
    { 
        //Definimos un rango entre 0 y 3 para los colores
        int n_colores = Random.Range(0, 4); //se incluye el 4 ya que se comporta como un intervalo semicerrado [0,4) y no lo incluye
        //Con el ciclo, evitamos que se asigne el mismo color, ya que si ambos numeros son iguales, vuelve a escoger
        //un número aleatorio
        while (n_colores==numero_color)
        {
            n_colores = Random.Range(0, 4);
        }
        //Asignamos el número aleatorio al número del color del jugador
        numero_color = n_colores;
        //Creamos un switch para asignar el color
        switch (n_colores)
        {
            case 0:
                color_actual = "Amarillo";
                sr.color = amarillo;
                break;
            case 1:
                color_actual = "Morado";
                sr.color = morado;
                break;
            case 2:
                color_actual = "Cyan";
                sr.color = cyan;
                break;
            case 3:
                color_actual = "Magenta";
                sr.color = magenta;
                break;

        }
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        //Condicional que hará que cada que se termine el click dado por el usuario se le aplique una fuerza al objeto para que salte
        if ((Input.GetButtonDown("Jump")|| Input.GetMouseButtonDown(0)) && MenuPausa.juego_pausado==false)
        {
            //al hacer el rimer click o apretar espacio por primera vez, se eliminan las características isKinetic y gravedad=0
            //para permitir el movimiento normal del jugador en el juego, además se quita el poder entrar a este condicional
            if(cero_clicks)
            {
                cero_clicks = false;
                rb.gravityScale = 3;
                rb.isKinematic = false;
            }
            //se le asigna una velocidad al RigidBody en unidades por segundo, que será igual a la fuerza del salto desplazada
            //hacia arriba en un vector de dos dimensiones con coordenadas (x,y)
            rb.velocity = Vector2.up * fuerza_salto;
        }
    }
}
