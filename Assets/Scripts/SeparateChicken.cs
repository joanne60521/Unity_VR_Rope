using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class SeparateChicken : MonoBehaviour
{
    public GameObject chicken1;
    public GameObject chicken2;
    public string chickenSuccess = "chickenSuccess";
    public float distance;
    public bool backToOrigin = false;

    public XRGrabInteractable XRGrabInteractable_1;
    public XRGrabInteractable XRGrabInteractable_2;

    
    private Vector3 heading;

    public TextMeshProUGUI myText = null;
    public TextMeshProUGUI myText1 = null;
    public float needHoldTime = 3.0f;
    private float enterTime;
    private float duration;
    private bool timerStart = false;

    void Start()
    {
        myText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();
        myText1 = GameObject.Find("Text1").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        heading = chicken1.transform.position - chicken2.transform.position;
        distance = heading.magnitude;
        if (distance > 1 && XRGrabInteractable_1.isSelected && XRGrabInteractable_2.isSelected && !backToOrigin)
        {
            if (!timerStart)
            {
                enterTime = Time.time;
                timerStart = true;
            }

            duration = Time.time - enterTime;
            myText.text = "hold  " + Mathf.Ceil(needHoldTime - duration).ToString() + "s";
            myText1.text = "hold  " + Mathf.Ceil(needHoldTime - duration).ToString() + "s";

            if (duration >= needHoldTime)
            {
                backToOrigin = true;
                myText.text = "Good Job";
                myText1.text = "Good Job";
                timerStart = false;
                chicken1.tag = chickenSuccess;
                chicken2.tag = chickenSuccess;
                Destroy(gameObject);
            }
        }else
        {
            myText.text = "pull more!";
            myText1.text = "pull more!";
            timerStart = false;
        }
    }
}
