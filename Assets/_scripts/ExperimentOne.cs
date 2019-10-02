using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperimentOne : MonoBehaviour {

    public GameObject playerTooltip;
    public Text[] progress;
    public GameObject[] blackboardTexts;
    public GameObject[] experimentMaterials;
    public GameObject congrats;
    private int numberOfSteps = 0;
    private bool stepOne = false;
    private bool stepTwo = false;
    private bool stepThree = false;
    private bool stepFour = false;


    private void OnCollisionEnter(Collision collision)
    {

       
        if(stepOne == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepOne = true;
                numberOfSteps++;
                progress[0].text = "Done";
            }
        }

        if (stepOne == true && stepTwo == false )
        {
  
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {             
                stepTwo = true;
                numberOfSteps++;
                progress[1].text = "Done";
            }
        }

        if (stepTwo == true && stepThree == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepThree = true;
                numberOfSteps++;
                progress[2].text = "Done";
            }
        }

        if (stepThree == true && stepFour == false)
        {
            if (collision.gameObject.name == experimentMaterials[numberOfSteps].name)
            {
                stepFour = true;
                numberOfSteps++;
                progress[3].text = "Done";
            }
        }

        else
        {
            playerTooltip.SetActive(true);
        }
    }

    void Update()
    {
         

    }

    void FinishExperiment()
    {
        for(int x = 0; x <= 4; x++)
        {
            blackboardTexts[x].SetActive(false);
        }
        congrats.SetActive(true);

    }
}
