using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRotation : MonoBehaviour
{

    [SerializeField]
    [Tooltip("回転するスピード")]
    private float MinSpeed;

    [SerializeField]
    [Tooltip("加速")]
    float kasoku; //test1
    // Update is called once per frame
    void Update()
    {


        // 現在のGameObjectのY軸方向の角度を取得
        float floorZAngle = transform.eulerAngles.z;
        float floorXAngle = transform.eulerAngles.x;

        //test1 加速
        MinSpeed = 0.1f;

        //kasoku = MinSpeed * Time.deltaTime;
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            if (floorXAngle < 30f)
            {
                MinSpeed += 0.1f;
                transform.Rotate(MinSpeed, 0f, 0f);
            }

        }
        //else if (Input.GetAxisRaw("Vertical") < 0)
        //{
        //    if (floorXAngle > -30f)
        //    {
        //        transform.Rotate(-MinSpeed, 0f, 0f);
        //    }
        //}
        else
        {
            MinSpeed = 0.1f;
            if (floorXAngle > 0 || floorXAngle < 0)
            {
                transform.Rotate(floorXAngle / -18f, 0f, 0f);
            }
        }

        //if (Input.GetAxisRaw("Horizontal") < 0)
        //{

        //    if (floorZAngle < 30f)
        //    {
        //        transform.Rotate(0f, 0f, MinSpeed);
        //    }
        //}
        //else if (Input.GetAxisRaw("Horizontal") > 0)
        //{
        //    if (floorZAngle > -30f)
        //    {
        //        transform.Rotate(0f, 0f, -MinSpeed);
        //    }
        //}
        //else
        //{
        //    if (floorZAngle > 0 || floorZAngle < 0)
        //    {
        //        transform.Rotate(0f, 0f, floorZAngle / -8f);
        //    }
        //}
    }
}
