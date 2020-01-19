using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BiologyExperimentOne : MonoBehaviour
{

    public GameObject playerTooltip;
    public GameObject finalObject;
    public GameObject congrats;
    public GameObject nextStep;
    public GameObject process;

    public Text nextStepCanvas;
    public Text[] progress;

    public GameObject[] blackboardTexts;
    public GameObject[] experimentMaterials;

    public AudioSource right;
    public AudioSource wrong;
    public AudioSource explain;

    public string[] instructions;

    private int numberOfSteps = 0;

    //private float secondsToDecay = 7.0f;

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
               // Collider m_Collider = experimentMaterials[numberOfSteps].GetComponent<Collider>();
               
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
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                progress[1].text = "Done";
                right.Play();
            }
        }

        if (stepTwo == true && stepThree == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepThree = true;
                numberOfSteps++;
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                progress[2].text = "Done";
                right.Play();
            }
        }

        if (stepThree == true && stepFour == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepFour = true;
                numberOfSteps++;
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                progress[3].text = "Done";
                right.Play();
            }
        }

        if (stepFour == true && stepFive == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepFive = true;
                numberOfSteps++;
                nextStepCanvas.text = "" + instructions[numberOfSteps];
                progress[4].text = "Done";
                right.Play();
            }
        }

        if (stepFive == true && stepSix == false)
        {
            if (collision.gameObject.CompareTag("Step 6"))
            {
                stepSix = true;
                numberOfSteps++;
                nextStepCanvas.text = "" + instructions[numberOfSteps-1];
                progress[5].text = "Done";
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
        if (stepSix == true)
        {
            process.SetActive(true);
            finishExperiment();
        }
    }

    void finishExperiment()
    {
        for (int x = 1; x <= 6; x++)
        {
            blackboardTexts[x-1].SetActive(false);
        }

        congrats.SetActive(true);

        Destroy(GameObject.FindWithTag("Step 1"));
        Destroy(GameObject.FindWithTag("Step 2"));
        Destroy(GameObject.FindWithTag("Step 3"));
        Destroy(GameObject.FindWithTag("Step 4"));
        Destroy(GameObject.FindWithTag("Step 5"));
        Destroy(GameObject.FindWithTag("Step 6"));

        explain.Play();
        nextStepCanvas.text = "Done";
        nextStep.SetActive(true);
        Invoke("SpawnProcess", 1);
        Destroy(process, 10);
        Invoke("SpawnFinale", 11);
        Destroy(finalObject, 22);

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
