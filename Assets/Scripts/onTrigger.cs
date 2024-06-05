using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onTrigger : MonoBehaviour
{
    public bool triggerEnter = false;
    public bool triggerStay = false;
    public bool destroy = false;
    public PullandHold pullandHold;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "chicken")
        {
            triggerEnter = true;
        }
    }
    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "chicken")
        {
            triggerEnter = false;
            triggerStay = true;
            if (destroy)
            {
                Destroy(col.gameObject);
                destroy  = false;
                triggerStay = false;
            }
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "chicken")
        {
            triggerStay = false;
        }
    }
}
