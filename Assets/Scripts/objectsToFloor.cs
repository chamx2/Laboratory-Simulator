using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objectsToFloor : MonoBehaviour {

   // private static bool countFrom; // hold the count start from the hit the floor script

    public GameObject items; // the item that will be dragged and dropped
    public GameObject tempParent; // where the item's hiearchy will be temporarily replaced

    public Transform floor; // the floor as referrence by it's position to the cartesian plane.
    public Transform guide; // the temporary replacement of the object's position

    public Text[] specs; // where the data regarding this object to be placed of.

    private float distanceToFloor; //  the distance from where you started to drop it.
    private float timeToFall; // This time is based on the time inside the engine/game.
    private static bool countFrom; //signal to start counting the seconds to fall of the object

    void Start()
    {
        Debug.Log(items.name);
        items.GetComponent<Rigidbody>().useGravity = true; // make sure the rigidbody's gravity physics is on
        specs[0].text = items.name;// get the object dragged's name and display
    }

    // this occurs on click
    public void letGoObject()
    {
     // if(Input.GetMouseButtonUp(0))
  	 // {
        items.GetComponent<Rigidbody>().useGravity = false; //make the gravity false so the object will float in front of you like it's being hold onto
        items.GetComponent<Rigidbody>().isKinematic = true; // to make sure no other physics will affect the object while being held
        items.transform.position = guide.transform.position;
        items.transform.parent = tempParent.transform;
     // }
    }

    //occurs on holding up

    public void clickObject()
    {
     // if(Input.GetMouseButtonDown(0))
  	//	{
        items.GetComponent<Rigidbody>().useGravity = true;
        items.GetComponent<Rigidbody>().isKinematic = false;
        items.transform.parent = null;
        items.transform.position = guide.transform.position;
        distanceToFloor = items.transform.position.y - floor.position.y; // compute the distance from the last place before dropping
        specs[1].text ="Distance:" + distanceToFloor.ToString() + "meters"; // display the distance data
        countFrom = true; // execute counting before hitting the floor
     // }
    }

    void Update()
    {
        //if true start counting
        if(countFrom == true)
        {
            timeToFall = timeToFall + Time.deltaTime;
            specs[3].text = timeToFall.ToString() + " seconds";
            countFrom = hitTheFloor.countStart; //  hitTheFloor.cs script's countStart variable
        }

       
    }
}
