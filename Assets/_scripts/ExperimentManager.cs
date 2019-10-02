using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentManager : MonoBehaviour {


    public GameObject[] requirments;
    public int numberOfRequirments;
    bool done;

	// Use this for initialization
	void Start ()
    {
        for (int num = 0; num <= numberOfRequirments - 1; num++)
        {
            requirments[num].SetActive(true);
        }
    }
	

}
