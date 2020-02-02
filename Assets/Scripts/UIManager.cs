using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class UIManager : MonoBehaviour {

    public static UIManager instance;
    public Text scoreText;
    public Text timeText;
    public Text resultText;
    public void Awake()
    {
        instance = this;
        UpdateUI();
        UpdateTime(1, 0);
        resultText.text = "";
    }



    public void UpdateTime(int min, int seconds)
    {
        timeText.text = min.ToString("D2") + ":" + seconds.ToString("D2");
    }
    public  void UpdateUI()
    {
        scoreText.text = "Score: " + ScoreManager.ReadScore();
    }

}
