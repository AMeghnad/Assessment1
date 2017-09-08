using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public int score = 0; // Sets the inital score to zero


	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}
}
