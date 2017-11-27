using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    [SerializeField] ScoreManager manager;
    int score;

    Text scoreLabel;

	// Use this for initialization
	void Start () {

        score = manager.score;

        scoreLabel = GetComponentInChildren<Text>();
        scoreLabel.text = score.ToString();

	}

    public void ScoreHit(int scorePerHit) {

        score += scorePerHit;
        scoreLabel.text = score.ToString();
        manager.score = score;
    }

}
