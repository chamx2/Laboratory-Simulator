using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PhysicsExperimentOne : MonoBehaviour {

    public Text[] progress;

    public GameObject[] blackboardTexts;
    public GameObject[] experimentMaterials;

    public GameObject congrats;
    public GameObject playerTooltip;
    public GameObject nextPortal;

    public AudioSource right;
    public AudioSource wrong;

    private bool stepOne = false;
    private bool stepTwo = false;

    private int numberOfSteps = 0;

    private float secondsToDecay = 10.0f;


    private void OnCollisionEnter(Collision collision)
    {
        if (stepOne == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepOne = true;
                numberOfSteps++;
                progress[0].text = "Done";
                right.Play();
            }
        }

        if (stepOne == true && stepTwo == false)
        {

            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepTwo = true;
                numberOfSteps++;
                progress[1].text = "Done";
                right.Play();
            }
        }

        else
        {
            playerTooltip.SetActive(true);
            wrong.Play();
        }
    }

    void Update()
    {
        if(stepOne == true && stepTwo == true)
        {
            finishExperiment();


        }
    }

    void finishExperiment()
    {


        for (int x = 1; x <= 5; x++)
        {
            blackboardTexts[x-1].SetActive(false);
        }

        congrats.SetActive(true);

        for (int i = 1; i <= 2; i++)
        {
            experimentMaterials[i-1].SetActive(false);
        }

        nextPortal.SetActive(true);

        wrong.Play();


    }
}
