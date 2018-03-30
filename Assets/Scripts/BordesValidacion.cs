using UnityEngine;
using System.Collections;

public class BordesValidacion : MonoBehaviour {
	//variable boolenaa;
	private bool Muestra = false;
	//variableS para acceder al GUI



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Entro en el disparador:
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name=="Armadura")
		{
			Muestra = true;

		}

	}

	//Salio del disparador:
	void OnTriggerExit (Collider Este)
	{
		if (Este.gameObject.name=="Armadura")
		{
			Muestra = false;
		}
	}




	void OnGUI()
	{
		
		if(Muestra)
		{

			GUI.contentColor = Color.red;
//			GUI.skin.label.font = "Godzilla";
			GUI.Label (new Rect (550, 250, 650, 600), "No se choque con el muro","Color");
		
			//Application.Quit ();

		}
	}

}
