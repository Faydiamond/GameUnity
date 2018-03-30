using UnityEngine;
using System.Collections;

public class ValidarBalas : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider other)
	{


		if(other.gameObject.name=="Sphere(Clone)")
		{
			print ("Destuyendo balas");
			Destroy (other.gameObject);
		}

	}
}
