using UnityEngine;


	public class AutoRotation : MonoBehaviour
	{
		public float degPerSec = 60.0f;


		public Vector3 rotAxis = Vector3.up;


		private void Start()
		{
			rotAxis.Normalize();
		}


		private void Update()
		{
			transform.Rotate(rotAxis, degPerSec * Time.deltaTime);
		}
	}
