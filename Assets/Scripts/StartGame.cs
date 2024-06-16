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
    public GameObject EndCanvas;
    public GameObject RayInteractor;
    public GameObject RayInteractor1;
    public TextMeshProUGUI InfoText;
    public TextMeshProUGUI InfoText1;
    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI TimeText1;
    public TextMeshProUGUI Score;
    public GameObject imgGrab;
    public GameObject imgGrab1;


    public float timer = 0;
    public float duration = 30;

    public int start = 0;
    public DestroySuccessed destroySuccessed;
    public HighscoreTable highscoreTable;

    void Awake()
    {
        InitiateChicken.SetActive(false);
        DestoryBox.SetActive(false);
        DestroyAll.SetActive(false);
        Canvas.SetActive(false);
        Canvas1.SetActive(false);
        EndCanvas.SetActive(false);
        StartCanvas.SetActive(true);
        RayInteractor.SetActive(true);
        RayInteractor1.SetActive(true);
    }

    void Update()
    {
        if (start == 0)  //title
        {
            // InitiateChicken.SetActive(false);
            // DestoryBox.SetActive(false);
            // DestroyAll.SetActive(false);
            // Canvas.SetActive(false);
            // Canvas1.SetActive(false);
            EndCanvas.SetActive(false);
            StartCanvas.SetActive(true);
            // RayInteractor.SetActive(true);
            // RayInteractor1.SetActive(true);
        }
        else if (start == 1)  //start game
        {
            InitiateChicken.SetActive(true);
            DestoryBox.SetActive(true);
            DestroyAll.SetActive(true);
            Canvas.SetActive(true);
            Canvas1.SetActive(true);
            imgGrab.SetActive(true);
            imgGrab1.SetActive(true);
            EndCanvas.SetActive(false);
            StartCanvas.SetActive(false);
            RayInteractor.SetActive(false);
            RayInteractor1.SetActive(false);
            start = 2;
            InfoText.text = "";
            InfoText1.text = "";
        }
        else if (start == 2)  //play game
        {
            TimeText.text = "TIME : " + Mathf.Floor(timer - Time.time).ToString();
            TimeText1.text = "TIME : " + Mathf.Floor(timer - Time.time).ToString();
            if (Time.time >= timer)
            {
                start = 3;
            }
        }
        else if (start == 3)  //end game
        {
            
            InitiateChicken.SetActive(false);
            DestoryBox.SetActive(false);
            // DestroyAll.SetActive(false);
            Canvas.SetActive(false);
            Canvas1.SetActive(false);
            EndCanvas.SetActive(true);
            StartCanvas.SetActive(false);
            RayInteractor.SetActive(true);
            RayInteractor1.SetActive(true);

            // string playerName = "Player" + round.ToString();
            // int score = destroySuccessed.successNumber;
            // highscoreTable.AddHighscoreEntry(score, playerName);

            Score.text = destroySuccessed.successNumber.ToString();
        }
    }

    public void StartOnClick()
    {
        start = 1;
        timer = Time.time + duration;
    }

    public void RestartOnClick()
    {
        start = 1;
        timer = Time.time + duration;
    }

    public void EndGameOnClick()
    {
        start = 0;
    }
}

