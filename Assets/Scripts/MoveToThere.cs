using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveToThere : MonoBehaviour
{
    public Transform there;
    public Transform originTransform;
    public SeparateChicken SeparateChicken;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SeparateChicken.backToOrigin)
        {
            //雞的手斷開
            transform.position = originTransform.position;
        }else
        {
            //雞的手在中間
            transform.position = there.position;
        }
    }
}
