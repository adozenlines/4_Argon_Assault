using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    int score;
    Text scoreText;

    public ScoreObject scoreObject;

    // Use this for initialization
    void Start()
    {
        // get last score from SO
        score = scoreObject.score;

        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    public void ScoreHit(int scoreIncrease)
    {
        score = score + scoreIncrease;
        //put current to SO, allows any other system to use score
        scoreObject.score = score;
        scoreText.text = score.ToString();
    }
}