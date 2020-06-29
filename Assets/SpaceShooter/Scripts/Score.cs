using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int scoreValue;

    private void Start()
    {
        scoreText.text = "Score: " + scoreValue;
    }

    public void AddPoints(int points)
    {
        scoreValue += points;

        scoreText.text = "Score: " + scoreValue;
    }

    public void ReducePoints(int points)
    {
        scoreValue -= points;
        scoreText.text = "Score: " + scoreValue;
    }
}
