using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour 
{

	public Transform[] spawnLocations;
	public GameObject[] whatToSpawnPrefab;
	public GameObject[] whatToSpawnClone;

	void Start()
	{
		spawnSomething();
	}
	void spawnSomething()
	{
		whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
	}




}
