using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveRight : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float closerSpeed = 0.1f;
    public Vector3 moveDirection = new(1, 0, 0);

    public XRGrabInteractable xRGrabInteractable;
    private bool grabedOnce = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isGrabed = xRGrabInteractable.isSelected;
        if (isGrabed)
        {
            grabedOnce = true;
            
        }else
        {
            transform.position += moveSpeed * Time.deltaTime * moveDirection;
        }
        if (grabedOnce && !isGrabed)
        {
            moveSpeed = 0;
        }
    }
}
