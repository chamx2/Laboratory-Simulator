using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetOrigins : MonoBehaviour {

    Vector3 originalPos;

    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {

       if(collision.gameObject.tag == "Border")
        {
            gameObject.transform.position = originalPos;
        }

    }

}
