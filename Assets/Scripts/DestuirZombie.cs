using UnityEngine;
using System.Collections;

public class DestuirZombie : MonoBehaviour {
	//Mi animacion
	public GameObject Explosion;
	public GameObject PlayerExplosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Entro en el disparador:
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name=="Sphere(Clone)")
		{
			Instantiate (Explosion,transform.position,transform.rotation);
			//Instantiate (PlayerExplosion,other.transform.position,other.transform.rotation);
			print ("Destuyendo Zombies");
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
		if (other.gameObject.name=="Armadura")
		{
			Instantiate (Explosion,transform.position,transform.rotation);
			Instantiate (PlayerExplosion,other.transform.position,other.transform.rotation);
			print ("Destuyendo Zombies y jugador");
			Destroy (other.gameObject);
			Destroy (gameObject);
			Application.Quit ();
		}

	}
}
