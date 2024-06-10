using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveChicken : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Vector3 moveDirection = new(0, 0, 1);
    
    private void OnTriggerStay(Collider col)
    {
        if (col.CompareTag("Chicken"))
        {
            col.transform.position += moveSpeed * Time.deltaTime * moveDirection;
        }
    }
}
