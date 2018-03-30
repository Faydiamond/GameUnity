using UnityEngine;
using System.Collections;

public class ValidaMuro : MonoBehaviour {

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
		if(other.gameObject.name=="Zommbiee(Clone)")
		{
			print ("Zombie colisiono con el muro,muere");
			Destroy (other.gameObject);
		}


	}
}
