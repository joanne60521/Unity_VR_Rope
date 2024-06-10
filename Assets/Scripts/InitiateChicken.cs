using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InitiateChicken : MonoBehaviour
{
    public GameObject chicken;
    public float timer = 4.0f;
    public bool create = false;
    public TextMeshProUGUI myText;


    void Start()
    {
        Instantiate(chicken, transform.position, transform.rotation);
    }

    void Update()
    {
        if (create)
        {
            Instantiate(chicken, transform.position, transform.rotation);
            // myText.text = "press middle finger to catch chicken";
            create = false;
        }
        if (Input.GetKeyDown("space"))
        {
            Instantiate(chicken, transform.position, transform.rotation);
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
