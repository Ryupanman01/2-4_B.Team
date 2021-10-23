using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private int score;   //スコア
    public Text ScoreText;  //スコアテキスト
    public Text ClearText;  //クリアテキスト
    public GameObject Item; //アイテム

    void Start()
    {
        score = 0;
        ClearText.text = "";
    }

    void Update()
    {
        SetCountText();
    }

    void OnCollisionEnter(Collision collision)
    {
        //衝突した相手にPlayerタグがついているとき
        if (collision.gameObject.CompareTag("Item"))
        {
            //その収集アイテムを非表示にする
            collision.gameObject.SetActive(false);
            //スコアを加算する
            score = score + 1;
            //ログ表示
            Debug.Log("当たった");
        }
    }

    void SetCountText()
    {
        ScoreText.text = score.ToString() + " / 12";

        //すべての収集アイテムを獲得した場合
        if(score >= 12)
        {
            //ゲームクリア表示
            ClearText.text = "GAME CLEAR";
        }
    }
}
