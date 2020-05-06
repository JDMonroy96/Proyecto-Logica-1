
using UnityEngine;
using UnityEngine.SceneManagement;
public class Script_Jugador : MonoBehaviour
{
    public float fuerza_salto = 10f;
    public Rigidbody2D rb;
    public string color_actual;
    public SpriteRenderer sr;
    public Color amarillo;
    public Color cyan;
    public Color morado;
    public Color magenta;

    private void Start()
    {
        asignarColor();
    }

    //Metodo que actuará cada que haya una colisión
    private void OnTriggerEnter2D(Collider2D collision)
    {
    //Condicional que indica si al haber contacto con el objeto de intercambio de color, asigne un color aleatorio
        if(collision.tag == "intercambio")
        {
            asignarColor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.tag != color_actual)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //Metodo que le asignará un color aleatorio al jugador al iniciar el juego
    private void asignarColor()
    { //Definimos un rango entre 0 y 3 para los colores
        int n_colores = Random.Range(0, 4); //se incluye el 4 ya que se comporta como un intervalo semicerrado [0,4) y no lo incluye
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

    void Update()
    {
        //Condicional que hará que cada que se termine el click dado por el usuario se le aplique una fuerza al objeto para que salte
        if (Input.GetButtonDown("Jump")|| Input.GetMouseButtonDown(0))
        {
            //se le asigna una velocidad al RigidBody en unidades por segundo, que será igual a la fuerza del salto desplazada
            //hacia arriba en un vector de dos dimensiones con coordenadas (x,y)
            rb.velocity = Vector2.up * fuerza_salto;
        }
    }
}
