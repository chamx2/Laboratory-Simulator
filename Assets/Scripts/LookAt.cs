using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {


	Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.FindGameObjectWithTag ("Player").transform;
		transform.rotation = Quaternion.LookRotation (transform.position - player.transform.position);
		//transform.LookAt (player.transform);
	}
}
