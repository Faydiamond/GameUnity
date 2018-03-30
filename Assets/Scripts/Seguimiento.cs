using UnityEngine;
using System.Collections;

public class Seguimiento : MonoBehaviour {

	//Mis variables:
	public GameObject Armadura;
	private Vector3 Distancia;

	// Use this for initialization
	void Start () 
	{
		Distancia = transform.position - Armadura.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//dele:
		transform.position=Armadura.transform.position+Distancia;

	}
}
