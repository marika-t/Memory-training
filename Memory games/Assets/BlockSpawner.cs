using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject blockPrefab;
	private float timeToSpawn = 2f;
	public float timeBetweenSpawns = 1f;

	// Use this for initialization
	void Update () 
	{
		if (Time.time >= timeToSpawn) {
			SpawnBlocks ();
			timeToSpawn = Time.time + timeBetweenSpawns;
		}
	}
	void SpawnBlocks()
	{
		int rnd = Random.Range (0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++) {
			if (rnd != i) {
				Instantiate (blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}
		}
	}

}
