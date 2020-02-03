using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public int sceneNumber;


	public void GameStart()
	{
		SceneManager.LoadScene(sceneNumber);
	}
}
