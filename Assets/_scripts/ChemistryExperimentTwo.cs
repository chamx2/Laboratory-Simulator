using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChemistryExperimentTwo : MonoBehaviour {

    public GameObject congrats;
    public GameObject playerTooltip;
    public GameObject final;
    public GameObject nextStep;

    public Text nextStepCanvas;
    public Text[] progress;

    public GameObject[] blackboardTexts;
    public GameObject[] experimentMaterials;


    public AudioSource right;
    public AudioSource wrong;
    public AudioSource explain;

    public string[] instructions;

    private int numberOfSteps = 0;

    private bool stepOne = false;
    private bool stepTwo = false;
    private bool stepThree = false;
    private bool stepFour = false;
    private bool stepFive = false;
    private bool stepSix = false;


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

        else if (stepOne == true && stepTwo == false)
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

        else if (stepTwo == true && stepThree == false)
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

        else if (stepThree == true && stepFour == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepFour = true;
                numberOfSteps++;
                progress[3].text = "Done";
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                right.Play();
            }
        }

        else if (stepFour == true && stepFive == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepFive = true;
                numberOfSteps++;
                progress[4].text = "Done";
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                right.Play();
            }
        }

        else if (stepFive == true && stepSix == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepSix = true;
                numberOfSteps++;
                progress[5].text = "Done";
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                right.Play();

            }
        }

        else
        {
            playerTooltip.SetActive(true);
            wrong.Play();
        }
    }

    private void Update()
    {
        if (stepSix == true)
            finishExperiment();
    }
    void finishExperiment()
    {

        for (int x = 1; x <= 5; x++)
        {
            blackboardTexts[x - 1].SetActive(false);
        }

        congrats.SetActive(true);

        for (int i = 1; i <= 5; i++)
        {
            experimentMaterials[i - 1].SetActive(false);
        }


        explain.Play();
        nextStepCanvas.text = "Done";
        nextStep.SetActive(true);
        final.SetActive(true);

    }
}
