using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoad : MonoBehaviour {

    public void loadSceneIndex(int indeX)
    {
        SceneManager.LoadScene(indeX);
    }
}
