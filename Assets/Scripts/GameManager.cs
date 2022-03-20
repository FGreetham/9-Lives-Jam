using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public TextMeshProUGUI livesText;
    private int lives;
    public TextMeshProUGUI outOfLivesText;
    public Button restartButton;
    //public Toggle music;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
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
            outOfLivesText.gameObject.SetActive(true);
            GameOver();
        }
    }


    public void GameOver()
    {
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        //music.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }


}
