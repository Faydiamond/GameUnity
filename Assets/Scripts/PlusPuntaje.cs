using UnityEngine;
using System.Collections;

public class PlusPuntaje : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	//detectando colison;
	void OnTriggerEnter(Collider Otro)
	{
		if (Otro.gameObject.name=="Sphere(Clone)")
		{
			print ("Puntuando ...");
			Puntaje.Puntacionn += 5;

		}
	}
}
