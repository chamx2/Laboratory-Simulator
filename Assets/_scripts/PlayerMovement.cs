using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Transform vrCamera;
	public float moveSpeed;
	private CharacterController cc;
    bool yesWalk = true;

	// Use this for initialization
	void Start ()
    {
		cc = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(yesWalk == true)
        { 
            if (Input.GetMouseButton(0))
            {
                Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
                cc.SimpleMove(forward * moveSpeed * Time.deltaTime);
            }
        }   
	}
}
