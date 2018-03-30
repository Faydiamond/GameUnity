using UnityEngine;
using System.Collections;

public class MoveZombie : MonoBehaviour 
{
	public float Velocidad;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * Velocidad;
	}

	// Update is called once per frame
	void Update () {

	}


}
