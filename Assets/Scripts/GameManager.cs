using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    int playTime = 60;
    int seconds;
    int minutes;

    int winTreshold = 1;
	// Use this for initialization
	void Start () {


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

        if (hasWon())
        {
            UIManager.instance.UpdateResult("Congratulations", Color.green);
        } else
        {
            UIManager.instance.UpdateResult("You lose", Color.red);
        }

        UIManager.instance.CleanCanvas();

    }

    bool hasWon()
    {
        return ScoreManager.ReadScore() >= winTreshold;
    }
}
