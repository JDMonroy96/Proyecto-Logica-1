using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control_Niveles : MonoBehaviour
{
	//Variables, que contienen los botónes de niveles a partir del 2 del menú de selección de nivel
	public Button nivel2, nivel3, nivel4, nivel5, nivel6, nivel7, nivel8, nivel9, nivel10;
	int nivel_completado;

	// Use this for initialization
	void Start()
	{
		//Al iniciar, se inactivan todos los botones y luego en el Switch, se verifica el nivel más alto pasado,
		//para reactivar los botones anteriores a este y el próximo a este
		nivel_completado = PlayerPrefs.GetInt("NivelCompletado");
		nivel2.interactable = false;
		nivel3.interactable = false;
		nivel4.interactable = false;
		nivel5.interactable = false;
		nivel6.interactable = false;
		nivel7.interactable = false;
		nivel8.interactable = false;
		nivel9.interactable = false;
		nivel10.interactable = false;

		switch (nivel_completado)
		{
			case 2:
				nivel2.interactable = true;
				break;
			case 3:
				nivel2.interactable = true;
				nivel3.interactable = true;
				break;
			case 4:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				break;
			case 5:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				break;
			case 6:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				break;
			case 7:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				break;
			case 8:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				break;
			case 9:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				nivel9.interactable = true;
				break;
			case 10:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				nivel9.interactable = true;
				nivel10.interactable = true;
				break;
					case 11:
				nivel2.interactable = true;
				nivel3.interactable = true;
				nivel4.interactable = true;
				nivel5.interactable = true;
				nivel6.interactable = true;
				nivel7.interactable = true;
				nivel8.interactable = true;
				nivel9.interactable = true;
				nivel10.interactable = true;
				
				
				break;
				
		}
	}

	//Método que carga el nivel, teniendo en cuenta el botón al que se haga click
	public void cargarNivel(int nivel)
	{
		SceneManager.LoadScene(nivel);
	}

	//Esta función se activa al presionar el botón de Resetear niveles y lo que hace, es desactivar todos los botónes
	//de los niveles entre 2 y 10 y ajustar la preferencia de NivelCompletado, para que no haya problemas con el método
	//de Start
	public void resetearNiveles()
	{
		nivel2.interactable = false;
		nivel3.interactable = false;
		nivel4.interactable = false;
		nivel5.interactable = false;
		nivel6.interactable = false;
		nivel7.interactable = false;
		nivel8.interactable = false;
		nivel9.interactable = false;
		nivel10.interactable = false;
		PlayerPrefs.SetInt("NivelCompletado", 1);
	}
}
