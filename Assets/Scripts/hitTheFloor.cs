using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitTheFloor : MonoBehaviour {

    public GameObject item;
    public static bool countStart = true;
    public static string itemname;
    private bool locker = false;

    private void OnCollisionEnter(Collision collision)
    {
       if(locker == false)
        {
            if (collision.gameObject.name == item.name)
            {
                countStart = false;
                locker = true;
            }
        }
    }
}
