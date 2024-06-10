using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateChicken : MonoBehaviour
{
    public Transform chicken1;
    public Transform chicken2;
    public float distance;
    private Vector3 heading;

    void Update()
    {
        heading = chicken1.position - chicken2.position;
        distance = heading.magnitude;
        Debug.Log(distance);
    }
}
