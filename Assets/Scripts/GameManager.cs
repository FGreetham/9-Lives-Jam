using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    private int lives;
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        lives = 9;
        UpdateLives(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

   public void UpdateLives(int livesToRemove)
    {
        lives -= livesToRemove;
        livesText.text = lives + "/9 Lives";
        if (lives == 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

}
