using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject leftTurn, rightTurn, pauseButton, resumeButton;


    public void Resume()
    {
        leftTurn.SetActive(true);
        rightTurn.SetActive(true);
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pauze()
    {
        leftTurn.SetActive(false);
        rightTurn.SetActive(false);
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
