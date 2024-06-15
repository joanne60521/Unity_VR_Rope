using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
using System.Threading;


public class StartGame : MonoBehaviour
{
    public GameObject InitiateChicken;
    public GameObject DestoryBox;
    public GameObject DestroyAll;
    public GameObject Canvas;
    public GameObject Canvas1;
    public GameObject StartCanvas;
    public GameObject RayInteractor;
    public GameObject RayInteractor1;
    public TextMeshProUGUI InfoText;
    public TextMeshProUGUI InfoText1;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI TimeText1;
    public float timer = 0;
    public float duration = 30;

    public int start = 0;

    void Start()
    {
        InitiateChicken.SetActive(false);
        DestoryBox.SetActive(false);
        DestroyAll.SetActive(false);
        Canvas.SetActive(false);
        Canvas1.SetActive(false);
        StartCanvas.SetActive(true);
        RayInteractor.SetActive(true);
        RayInteractor1.SetActive(true);
    }

    void Update()
    {
        if (start == 0)
        {
            InitiateChicken.SetActive(false);
            DestoryBox.SetActive(false);
            DestroyAll.SetActive(false);
            Canvas.SetActive(false);
            Canvas1.SetActive(false);
            StartCanvas.SetActive(true);
            RayInteractor.SetActive(true);
            RayInteractor1.SetActive(true);
        }
        else if (start == 1)
        {
            InitiateChicken.SetActive(true);
            DestoryBox.SetActive(true);
            DestroyAll.SetActive(true);
            Canvas.SetActive(true);
            Canvas1.SetActive(true);
            StartCanvas.SetActive(false);
            RayInteractor.SetActive(false);
            RayInteractor1.SetActive(false);
            start = 2;
            InfoText.text = "press middle finger to catch chicken";
            InfoText1.text = "press middle finger to catch chicken";
        }
        else if (start == 2)
        {
            TimeText.text = "TIME : " + Mathf.Floor(timer - Time.time).ToString();
            TimeText1.text = "TIME : " + Mathf.Floor(timer - Time.time).ToString();
            if (Time.time >= timer)
            {
                start = 0;
            }
        }
    }

    public void OnCliick()
    {
        start = 1;
        timer = Time.time + duration;
    }
}

