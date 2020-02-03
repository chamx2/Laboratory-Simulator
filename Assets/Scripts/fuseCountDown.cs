using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fuseCountDown : MonoBehaviour {

    public GameObject explode;
    public GameObject fuse;

    private float secondsToDecay = 4.0f;

    private void Awake()
    {
        fuse.gameObject.SetActive(true);
        explode.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        secondsToDecay -= Time.deltaTime;
        if (secondsToDecay <= 0)
        {
            fuse.gameObject.SetActive(false);
            explode.gameObject.SetActive(true);
            StartCoroutine(SceneSwitch());
        }
    }

    IEnumerator SceneSwitch()
    {
        yield return new WaitForSeconds(3);
        // DontDestroyOnLoad(transform.gameObject);
        SceneManager.LoadScene(1);
    }

}
