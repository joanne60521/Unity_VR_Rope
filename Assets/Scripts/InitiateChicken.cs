using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InitiateChicken : MonoBehaviour
{
    public GameObject chicken;
    public Transform _camera;
    public float timer = 4.0f;
    public bool create = false;
    public TextMeshProUGUI myText;


    void Start()
    {
        Instantiate(chicken, transform.position, transform.rotation);
        Instantiate(chicken, transform.position - new Vector3((float)0.2, 0, 0), transform.rotation);
    }

    void Update()
    {
        if (create)
        {
            Instantiate(chicken, transform.position, transform.rotation);
            Instantiate(chicken, transform.position - new Vector3((float)0.2, 0, 0), transform.rotation);
            // myText.text = "press middle finger to catch chicken";
            create = false;
        }
        if (Input.GetKeyDown("space"))
        {
            Instantiate(chicken, transform.position, transform.rotation);
            Instantiate(chicken, transform.position - new Vector3((float)0.2, 0, 0), transform.rotation);
            // myText.text = "press middle finger to catch chicken";
        }

        // timer -= Time.deltaTime;
        // if (timer <= 0)
        // {
        //     Instantiate(chicken, transform.position, transform.rotation);
        //     timer = 2.0f;
        // }
    }
}
