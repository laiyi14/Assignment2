using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class GameManager : MonoBehaviour
{
    //Components
    public TextMeshProUGUI timerText;
    public GameObject WinScreen;
    public GameObject LoseScreen;

    //Timer setting
    public float currentTime;
    public bool countdown;

    void Start()
    {
        
    }


    void Update()
    {
        currentTime = countdown ? currentTime -= Time.deltaTime 
                    : currentTime += Time.deltaTime;
        
        if(timerText)
        {
            timerText.text = currentTime.ToString("00:00");
        }

        if(currentTime <= 0)
        {
            currentTime = 0;
            WinScreen.SetActive(true);
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void LoseGame()
    {
        LoseScreen.SetActive(true);
        PauseGame();
    }
}
