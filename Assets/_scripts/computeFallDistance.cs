using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class computeFallDistance : MonoBehaviour {

    //public Transform objectDistance;
   // public Transform floorDistance;

    public GameObject characterPos;
    public GameObject floorPos;

    public Text[] specs;
    public float floorDist;
    private Vector3 posChar;
    private Vector3 posFloor;


    void Awake()
    {
        posChar = characterPos.transform.position;
        posFloor = floorPos.transform.position;
    }

    private void Start()
    {
        specs[0].text = characterPos.name;
    }

    void Update()
    {
        //floorDist = objectDistance.transform.position.y - floorDistance.transform.position.y;
        FloorMeasure();
        Debug.Log("Distance to Floor = " + floorDist);
    }

    void FloorMeasure()
    {


        RaycastHit hit;

        if (Physics.Linecast(posChar, posFloor, out hit))
        {
            floorDist = hit.distance;
            specs[1].text = floorDist.ToString();
        }
    }
}
