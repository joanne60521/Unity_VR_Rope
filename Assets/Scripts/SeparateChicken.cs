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


    public GameObject imgGrab;
    public GameObject imgGrab1;


    void Start()
    {
        myText = GameObject.Find("InfoText").GetComponent<TextMeshProUGUI>();
        myText1 = GameObject.Find("InfoText1").GetComponent<TextMeshProUGUI>();
        imgGrab = GameObject.Find("Img_Grab");
        imgGrab1 = GameObject.Find("Img_Grab1");
    }

    void Update()
    {
        heading = chicken1.transform.position - chicken2.transform.position;
        distance = heading.magnitude;
        if (distance > 1 && XRGrabInteractable_1.isSelected && XRGrabInteractable_2.isSelected && !backToOrigin)
        {
            imgGrab.SetActive(false);
            imgGrab1.SetActive(false);


            if (!timerStart)
            {
                enterTime = Time.time;
                timerStart = true;
            }

            duration = Time.time - enterTime;
            myText.text = "HOLD  " + Mathf.Ceil(needHoldTime - duration).ToString() + "s";
            myText1.text = "HOLD  " + Mathf.Ceil(needHoldTime - duration).ToString() + "s";

            if (duration >= needHoldTime)
            {
                backToOrigin = true;
                myText.text = "GREAT JOB";
                myText1.text = "GREAT JOB";
                timerStart = false;
                chicken1.tag = chickenSuccess;
                chicken2.tag = chickenSuccess;
                Destroy(gameObject);
            }
        }else
        {
            if (XRGrabInteractable_1.isSelected && XRGrabInteractable_2.isSelected)
            {
                imgGrab.SetActive(false);
                imgGrab1.SetActive(false);
                myText.text = "PULL MORE!";
                myText1.text = "PULL MORE!";
            }
            timerStart = false;
        }
    }
}
