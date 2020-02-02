using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOverScene : MonoBehaviour {

    public Text resultText;
    public Text scoreText;
    public Color color;
    // Use this for initialization
    void Start () {
        resultText.text = "You " + ScoreHolder.result;
        resultText.color = ScoreHolder.resultColor;
        scoreText.text = "Your Score: " + ScoreHolder.score;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Master");
        }
	}
}
