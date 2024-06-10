using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePosition : MonoBehaviour
{
    public Transform transform1;
    public Transform transform2;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = (transform2.position - transform1.position) / 2 + transform1.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (transform2.position - transform1.position) / 2 + transform1.position;
    }
}
