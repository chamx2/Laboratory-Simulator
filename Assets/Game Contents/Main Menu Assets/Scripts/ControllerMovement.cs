using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour {
	
	public float MovementSpeed;	 
	public GameObject player;	
		// public float RotationSpeed = 100.0f;
		
	void Update () {


		if(Input.GetMouseButton(0))
		{

			player.transform.position += transform.forward * Time.deltaTime * MovementSpeed;
			
		}

		 // 	float translation = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;

		 // 	transform.Translate(0,0,translation);
		 
		 // float translation = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;
		 // // float rotation = Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime;;
		 

		 // transform.Translate(0,0, translation);
		 // // transform.Rotate(rotation, 0, 0);

		
	}
}
