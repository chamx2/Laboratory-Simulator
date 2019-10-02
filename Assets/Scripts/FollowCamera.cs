using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	Transform Target;

	// Use this for initialization
	void Start () {

	}



	// Update is called once per frame
	void LateUpdate () {

		Target = GameObject.FindGameObjectWithTag ("MainCamera").transform;

		transform.position = Target.transform.position;
		transform.rotation = Target.transform.rotation;

	}
}
