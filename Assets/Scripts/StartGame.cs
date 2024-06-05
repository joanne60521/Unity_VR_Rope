using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class StartGame : MonoBehaviour
{
    public GameObject BornChicken1;
    public GameObject CollideBoxs;
    public InputActionReference startInputReferenceLeft;
    public InputActionReference startInputReferenceRight;
    public TextMeshProUGUI myText;

    private int start = 0;

    void Update()
    {
        float pressedStartLeft = startInputReferenceLeft.action.ReadValue<float>();
        float pressedStartRight = startInputReferenceRight.action.ReadValue<float>();
        if (start == 0 && pressedStartLeft == 1.0f || pressedStartRight == 1.0f)
        {
            start = 1;
        }
        if (start == 1)
        {
            BornChicken1.SetActive(true);
            CollideBoxs.SetActive(true);
            start = 2;
            myText.text = "press middle finger to catch chicken";
        }
    }
}
