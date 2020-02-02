using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {


    int playTime = 60;
    int seconds;
    int minutes;

    int winTreshold = 120;
	// Use this for initialization
	void Start () {

        if(ScoreManager.ReadScore() != 0)
        {
            ScoreManager.ResetScore();
            UIManager.instance.UpdateUI();
        }
  
        StartCoroutine("PlayTimer");
	}
	
    IEnumerator PlayTimer()
    {
        while (playTime > 0)
        {
            yield return new WaitForSeconds(1);
            playTime--;
            seconds = playTime % 60;
            minutes = playTime / 60 % 60;

            UIManager.instance.UpdateTime(minutes, seconds);
        }

        ScoreHolder.score = ScoreManager.ReadScore();
        if (hasWon())
        {
            ScoreHolder.result = "win";
            ScoreHolder.resultColor = Color.green;
        } else
        {
            ScoreHolder.result = "lose";
            ScoreHolder.resultColor = Color.red;
        }

        SceneManager.LoadScene("GameOver");

    }

    bool hasWon()
    {
        return ScoreManager.ReadScore() >= winTreshold;
    }
}
