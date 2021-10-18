using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text ScoreText; //Text用変数
    private int score;          //スコア計算用変数初期化

    void Start()
    {
        Initialize();
    }
    private void Initialize()
    {
        score = 1;
        ScoreText.text = "Score:" + score;
    }
    public void AddScore()
    {
        score += 1;
        ScoreText.text = "Score:" + score;
    }
}
