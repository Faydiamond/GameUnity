using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	

	public GameObject Zombies;
	public Vector3 SpawnValor;
	public int Cuantos;
	//espera de zombies;
	public float Espera;
	public float EsperaInicial;
	public float EsperaHorda;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(IntanciarZombies ());

	}
	
	// Update is called once per frame
	IEnumerator IntanciarZombies ()
	{
		yield return new WaitForSeconds (EsperaInicial);
		//Bucle infinito
		while (true)
		{
			for (int i = 0; i < Cuantos; i++)
			{
				Vector3 SpawnPos = new Vector3 (Random.Range(-SpawnValor.x,SpawnValor.x),SpawnValor.y,SpawnValor.z);
				Instantiate (Zombies, SpawnPos, Quaternion.identity);
				yield return new WaitForSeconds (Espera);
			}
			yield return new WaitForSeconds (EsperaHorda);
		}


	}
}
