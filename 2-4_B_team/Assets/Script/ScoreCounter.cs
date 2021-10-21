using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    int score = 0;
    public Text ScoreText;

    public void AddScore()
    {
        score++;
    }

    void Update()
    {
        ScoreText.text = "Count:" + score.ToString();
    }
}
