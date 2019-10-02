using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRigidBodyMove : MonoBehaviour {

	    public GameObject items;
		public GameObject tempParent;
		public Transform guide;

		// Use this for initialization
		void Start () {

		}


		void OnMouseDown()
		{

			transform.position = guide.transform.position;
			transform.rotation = guide.transform.rotation;

			// items.transform.parent = tempParent.transform.position;
		}

		void OnMouseUp()
		{

			items.transform.parent = null;
			items.transform.position = GameObject.FindGameObjectWithTag("Guide").transform.position;

		}
}
