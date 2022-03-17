using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private GameManager gameManager; 
    public float timeValue = 90f;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI outOfTimeText;


    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    void Update()
    {
        //Counts down the seconds
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        { //Stops it going below zero.
            timeValue = 0;
        }

        if(timeValue < 0)
        {
            outOfTimeText.gameObject.SetActive(true);
            gameManager.GameOver();
        }

        //Display Text
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        //Keeps it at zero rather than less than zero
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if(timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        //Works out Minutes and Seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
