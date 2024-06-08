using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PullandHold : MonoBehaviour
{
    public onTrigger onTriggerLeft;
    public onTrigger onTriggerRight;

    public float needHoldTime = 3.0f;
    public bool destroy = false;
    public TextMeshProUGUI myText;
    public InitiateChicken initiateChicken;

    private float enterTime;
    private float duration;
    private bool timerStart = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (onTriggerLeft.triggerStay && onTriggerRight.triggerStay)
        {
            if (!timerStart)
            {
                enterTime = Time.time;
                timerStart = true;
            }
            duration = Time.time - enterTime;
            myText.text = "hold  " + Mathf.Ceil(needHoldTime - duration).ToString() + "s";
            if (duration >= needHoldTime)
            {
                myText.text = "Success";
                onTriggerLeft.destroy = true;
                onTriggerRight.destroy = true;
                initiateChicken.create = true;
                timerStart = false;
            }
        }else
        {
            timerStart = false;
        }
    }
}
