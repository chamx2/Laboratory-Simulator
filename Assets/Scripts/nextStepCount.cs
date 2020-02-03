using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextStepCount : MonoBehaviour {

    public GameObject step1;
    public GameObject step2;

    private float secondsToDecay = 4.0f;


    private void Awake()
    {
        step1.SetActive(true);
        step2.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

        secondsToDecay -= Time.deltaTime;
        if (secondsToDecay <= 0)
        {
            step1.SetActive(false);
            step2.SetActive(true);
        }
    }
}
