using UnityEngine;
using System.Collections;

public class Camina : MonoBehaviour {
	private float Velocidad=1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float MoverHori = Input.GetAxis ("Horizontal");
		float MoverVer=Input.GetAxis("Vertical");
		Vector3 Mov = new Vector3 (MoverHori, 0.0f, MoverVer);
		GetComponent<Rigidbody>().AddForce (Mov * Velocidad * Time.deltaTime);
	}
}
