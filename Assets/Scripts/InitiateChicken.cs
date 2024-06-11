using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class InitiateChicken : MonoBehaviour
{
    public GameObject[] chicken;
    public int chickenIndex;
    public float timer = 4.0f;
    public float addTimeMin = 4.0f;
    public float addTimeMax = 8.0f;
    public bool create = false;
    public TextMeshProUGUI myText;
    public TextMeshProUGUI myText1;


    void Start()
    {
        chickenIndex = Random.Range(0, 3);
        Instantiate(chicken[chickenIndex], transform.position, transform.rotation);
        Debug.Log(chickenIndex);
    }

    void Update()
    {
        // if (create)
        // {
        //     Instantiate(chicken, transform.position, transform.rotation);
        //     // myText.text = "press middle finger to catch chicken";
        //     // myText1.text = "press middle finger to catch chicken";
        //     create = false;
        // }

        if (Input.GetKeyDown("space"))
        {
            chickenIndex = Random.Range(0, 3);
            Instantiate(chicken[chickenIndex], transform.position, transform.rotation);
            Debug.Log(chickenIndex);
            // myText.text = "press middle finger to catch chicken";
            // myText1.text = "press middle finger to catch chicken";
        }

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            chickenIndex = Random.Range(0, 3);
            Instantiate(chicken[chickenIndex], transform.position, transform.rotation);
            Debug.Log(chickenIndex);
            timer = chickenIndex + 1 + Random.Range(addTimeMin, addTimeMin);
            Debug.Log("timer: " + timer);
        }
    }
}
