using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabChicken : MonoBehaviour
{
    public InputActionReference selectInputActionReference;
    public float selectInput;
    private int triggeredObjectCount = 0;
    private GameObject currentTriggeredObject = null;

    private void OnTriggerEnter(Collider col)
    {
        triggeredObjectCount++;
        if (triggeredObjectCount == 1)
        {
            currentTriggeredObject = col.gameObject;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        triggeredObjectCount--;

        if (col.gameObject == currentTriggeredObject)
        {
            currentTriggeredObject = null;
        }
    }
    
    private void OnTriggerStay(Collider col)
    {
        selectInput = selectInputActionReference.action.ReadValue<float>();
        if (currentTriggeredObject != null && col.gameObject != currentTriggeredObject)
        {
            return;
        }
        else if (col.CompareTag("Chicken") && selectInput >= 1)
        {
            col.gameObject.transform.position = transform.position;
            col.gameObject.transform.rotation = transform.rotation;
        }
    }
}
