using UnityEngine;
using System.Collections;

public class RotatePlanets : MonoBehaviour {

    public GameObject itemOne;
    public GameObject itemTwo;
    public GameObject itemThree;
    public GameObject itemFour;
    public GameObject itemFive;
    public GameObject itemSix;
    public GameObject itemSeven;
    public GameObject itemEight;
    public GameObject itemNine;

    public int Speed = 60;
    public int SpeedDown = 80;
    public int SpeedLeft = 60;

	
	// Update is called once per frame
	void Update () {

        itemOne.transform.Rotate (Vector3.right * Time.deltaTime * Speed);
        itemTwo.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemThree.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemFour.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemFive.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemSix.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemSeven.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemEight.transform.Rotate(Vector3.right * Time.deltaTime * Speed);
        itemNine.transform.Rotate(Vector3.right * Time.deltaTime * Speed);


        itemOne.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemTwo.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemThree.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemFour.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemFive.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemSix.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemSeven.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemEight.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);
        itemNine.transform.Rotate(Vector3.down * Time.deltaTime * SpeedDown);


        itemOne.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemTwo.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemThree.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemFour.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemFive.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemSix.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemSeven.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemEight.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);
        itemNine.transform.Rotate(Vector3.left * Time.deltaTime * SpeedLeft);




    }
}
