using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseIntructions : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject instructions;

	// Use this for initialization
	void Start () {

		mainMenu.SetActive (false);
		instructions.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenMenu () {

		mainMenu.SetActive (true);
		Destroy (instructions.gameObject);
	}
}
