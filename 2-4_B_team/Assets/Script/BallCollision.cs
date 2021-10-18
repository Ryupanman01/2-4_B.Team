﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //衝突した相手にPlayerタグがついているとき
        if(collision.gameObject.tag == "Player")
        {
            //0.2秒後に消える
            Destroy(gameObject, 0.2f);
        }
        Debug.Log("当たった");
    }
}
