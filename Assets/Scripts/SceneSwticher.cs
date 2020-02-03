using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwticher : MonoBehaviour {

	public GameObject FadeOut;
	public int sceneIndex;

	void Start ()
    {
		FadeOut.SetActive (false);
	}
	
	void OnTriggerEnter (Collider other)
    {

		if (other.gameObject.tag == "Player")
        {
			StartCoroutine (SceneSwitch ());

		}
	}

 //   public void SceneMobileExit()
	//{
	//	Application.Quit();
	//}

    public void SceneSwitchButton()
    {
        StartCoroutine(SceneSwitch());
    }

    IEnumerator SceneSwitch ()
    {
		FadeOut.SetActive (true);
		yield return new WaitForSeconds (3);
		SceneManager.LoadSceneAsync (sceneIndex);
	}

	
}
