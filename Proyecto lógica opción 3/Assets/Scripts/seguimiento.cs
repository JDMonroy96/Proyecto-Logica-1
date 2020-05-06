using UnityEngine;



public class seguimiento : MonoBehaviour
{
    //Referenciaremos al jugador para que la camara le haga acompañamiento continuo
    public Transform player;

    private void Update()
    {
      //Condicional que verificará si la posición del jugador pasó la posición actual y le asignará la nueva posición a la camara
      if(player.position.y > transform.position.y)//ya que el desplazamiento es en el eje y se usa este parametro .y
        {
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }
}
