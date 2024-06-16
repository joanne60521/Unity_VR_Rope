using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
    public AudioClip buttonClick;

    public void PlayButtonAudio()
    {
        AudioSource.PlayClipAtPoint(buttonClick, transform.position, 1f);
    }
}
