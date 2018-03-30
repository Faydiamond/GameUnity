using UnityEngine;
using System.Collections;

public class ClonandoZombies : MonoBehaviour {

	//Declration variables
	public GameObject KoreanZombie;
	//Posicion d elos huevos aleatoria:
	public Vector3 spawnValues;

	public int CantidadHuevos;
	public float spawnWait;
	public float waveWait;
	public float startWait ;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnWaves ());
	}

	// Update is called once per frame
	void Update () {

	}
	/*
	void SpawnWaves()
	{
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x),spawnValues.y,spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (Egss,spawnPosition,spawnRotation);

	}*/

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for(int i=0; i<CantidadHuevos;i++)
			{
				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x),spawnValues.y,spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				//Instantiate (Egss, spawnPosition, spawnRotation);
				Instantiate (KoreanZombie,spawnPosition,spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}

}
