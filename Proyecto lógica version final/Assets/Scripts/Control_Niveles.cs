using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control_Niveles : MonoBehaviour
{
	public Button nivel2, nivel3, nivel4, nivel5, nivel6, nivel7, nivel8, nivel9, nivel10;
	int nivel_completado;

	// Use this for initialization
	void Start()
	{
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

	public void cargarNivel(int nivel)
	{
		SceneManager.LoadScene(nivel);
	}

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
