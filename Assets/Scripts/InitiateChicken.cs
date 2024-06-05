using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InitiateChicken : MonoBehaviour
{
    public GameObject chicken;
    public Transform _camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(chicken,new Vector3(transform.position.x, (float)(_camera.position.y-0.3), transform.position.z), transform.rotation);
        }
    }
}
