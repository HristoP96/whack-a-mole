using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class UIManager : MonoBehaviour {

    public static UIManager instance;

    public void Awake()
    {
        instance = this;
        UpdateUI();
    }

    public Text scoreText;
    
    public  void UpdateUI()
    {
        scoreText.text = "Score: " + ScoreManager.ReadScore();
    }
}
