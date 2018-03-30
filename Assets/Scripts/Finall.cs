using UnityEngine;
using System.Collections;

public class Finall : MonoBehaviour 
{
	private bool Este = false;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider Finn)
	{
		if (Finn.gameObject.name=="Armadura")
		{
			Este = true;
		}
	}



	void OnGUI()
	{

		if(Este)
		{

			GUI.contentColor = Color.blue;
			//			GUI.skin.label.font = "Godzilla";
			GUI.Label (new Rect (550, 250, 650, 600), "Felicidades has ganado!.","Color");

			//Application.Quit ();

		}
	}
}
