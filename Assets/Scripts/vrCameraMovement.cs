using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrCameraMovement : MonoBehaviour {


	public Transform vrCamera;

	public float moveSpeed = 50.0f;

	private CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton(0))
		{
			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

			cc.SimpleMove(forward * moveSpeed * Time.deltaTime);
		}
	}
}
