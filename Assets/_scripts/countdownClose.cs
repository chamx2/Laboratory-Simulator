using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdownClose : MonoBehaviour {

    private float secondsToDecay = 5.0f;
    // Use this for initialization
    private void Awake()
    {
        secondsToDecay = 5.0f;
    }

    // Update is called once per frame
    void Update () {
        secondsToDecay -= Time.deltaTime;
            if(secondsToDecay <= 0)
            {
            this.gameObject.SetActive(false);
            }
	}
}
