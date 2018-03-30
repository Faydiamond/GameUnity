using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Navegacion : MonoBehaviour 
{
	public void Jugarr()
	{
		SceneManager.LoadScene ("Juego");
	}

	public void Salirr()
	{
		Application.Quit ();
	}

	public void Instruc()
	{
		SceneManager.LoadScene ("Instrucciones");	
	}

}
