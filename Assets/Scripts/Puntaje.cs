using UnityEngine;
using System.Collections;

public class Puntaje : MonoBehaviour 
{
	public static int Puntacionn;
	private int Final = 1000;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnGUI()
	{
		GUI.Label (new Rect (800, 20, 100, 180), "Puntuacion" +Puntacionn);
		//ValidaCION	
		if (Puntacionn>=Final) 
		{
			GUI.Label (new Rect (400, 200, 300, 480), "Sos el ganador");
		}
	}

}
