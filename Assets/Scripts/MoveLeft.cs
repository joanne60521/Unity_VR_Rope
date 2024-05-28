using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float forwardSpeed = 1.0f;
    [SerializeField] float closerSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * forwardSpeed * Time.deltaTime;
        transform.position += new Vector3(-1, 0, 0) * closerSpeed * Time.deltaTime;

    }
}
