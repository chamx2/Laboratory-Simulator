using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public int sceneNumber;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	public void GameStart()
	{
		SceneManager.LoadScene(sceneNumber);
	}
}
