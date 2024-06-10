using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class DestroySuccessed : MonoBehaviour
{
    public int successNumber = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreText1;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("chickenSuccess"))
        {
            Debug.Log("destroy");
            Destroy(col.gameObject);
            successNumber++;
            scoreText.text = "good chicken: " + successNumber.ToString();
            scoreText1.text = "good chicken: " + successNumber.ToString();
        }
    }
}
