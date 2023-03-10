using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOver;
    public int highestScore;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
         playerScore = playerScore + scoreToAdd;
         scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOverscreen()
    {
        gameOver.SetActive(true);
    }


}
