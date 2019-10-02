using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PhysicsExperimentThree : MonoBehaviour {

    public GameObject playerTooltip;

    public GameObject[] blackboardTexts;
    public GameObject[] experimentMaterials;
    public GameObject finalObject;
    public GameObject congrats;
    public GameObject process;

    public Text nextStepCanvas;
    public Text[] progress;

    public AudioSource right;
    public AudioSource wrong;
    public AudioSource explain;

    public string[] instructions;

    private int numberOfSteps = 0;

    private bool stepOne = false;
    private bool stepTwo = false;
    private bool stepThree = false;
    private bool stepFour = false;

    private void Start()
    {
        nextStepCanvas.text = "" + instructions[0];
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (stepOne == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepOne = true;
                numberOfSteps++;
                progress[0].text = "Done";
                nextStepCanvas.text = "" + instructions[numberOfSteps];
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
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                right.Play();
            }
        }

        if (stepTwo == true && stepThree == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepThree = true;
                numberOfSteps++;
                progress[2].text = "Done";
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                right.Play();
            }
        }

        else
        {
            playerTooltip.SetActive(true);
        }
    }

    void Update()
    {
        if (stepThree == true)
        {
            process.SetActive(true);
            finishExperiment();
        }

    }

    void finishExperiment()
    {
        for (int x = 1; x <= 5; x++)
        {
            blackboardTexts[x - 1].SetActive(false);
        }

        congrats.SetActive(true);

        Destroy(GameObject.FindWithTag("Step 1"));
        Destroy(GameObject.FindWithTag("Step 2"));
        Destroy(GameObject.FindWithTag("Step 3"));

        explain.Play();
        nextStepCanvas.text = "Done";
        Invoke("SpawnProcess", 1);
        Destroy(process, 7);
        Invoke("SpawnFinale", 8);
        Destroy(finalObject, 18);

    }

    void SpawnProcess()
    {
        process.SetActive(true);
    }

    void SpawnFinale()
    {
        finalObject.SetActive(true);
    }


   
}
