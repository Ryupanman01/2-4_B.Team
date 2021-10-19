using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLimit : MonoBehaviour
{
    [SerializeField]
    [Tooltip("最小角度(-180～180")]
    private float MinAngle;

    [SerializeField]
    [Tooltip("最大角度(-180～180")]
    private float MaxAngle;

    [SerializeField]
    [Tooltip("回転するスピード")]
    private float rotationSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        // 左右キーの入力を取得
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 現在のGameObjectのY軸方向の角度を取得
        float floorZAngle = transform.eulerAngles.z;
        float floorXAngle = transform.eulerAngles.x;

        // 現在の角度が180より大きい場合
        if (floorZAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            floorZAngle = floorZAngle - 360;
        }
        if (floorXAngle > 180)
        {
            // デフォルトでは角度は0～360なので-180～180となるように補正
            floorXAngle = floorXAngle - 360;
        }

        //// (現在の角度が最小角度以上かつキー入力が0未満(左キー押下)) または (現在の角度が最大角度以下かつキー入力が0より大きい(右キー押下))の時
        //if ((floorZAngle >= MinAngle && -horizontal < 0) || (floorZAngle <= MaxAngle && -horizontal > 0))
        //{
        //    // Y軸を基準に回転させる
        //    transform.Rotate(new Vector3(0, 0, -horizontal * rotationSpeed));
        //}
        //else
        //{
        //    if (floorZAngle > 0 || floorZAngle < 0)
        //    {
        //        transform.Rotate(0f, 0f, floorZAngle / -8f);
        //    }
        //}

        //// (現在の角度が最小角度以上かつキー入力が0未満(左キー押下)) または (現在の角度が最大角度以下かつキー入力が0より大きい(右キー押下))の時
        //if ((floorXAngle >= MinAngle && vertical < 0) || (floorXAngle <= MaxAngle && vertical > 0))
        //{
        //    // Y軸を基準に回転させる
        //    transform.Rotate(new Vector3(vertical * rotationSpeed, 0, 0));
        //}
        //else
        //{
        //    if (floorXAngle > 0 || floorXAngle < 0)
        //    {
        //        transform.Rotate(floorXAngle / -8f, 0f, 0f);
        //    }
        //}

        //if (Input.GetKey("up"))
        //{
        //    if (floorXAngle < 30f)
        //    {
        //        transform.Rotate(1f, 0f, 0f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.x > 0)
        //    {
        //        transform.Rotate(floorXAngle / -8f, 0f, 0f);
        //    }
        //}
        //if (Input.GetKey("down"))
        //{
        //    if (floorXAngle > -30f)
        //    {
        //        transform.Rotate(-1f, 0f, 0f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.x > 0)
        //    {
        //        transform.Rotate(-floorXAngle / 8f, 0f, 0f);
        //    }
        //}

        //if (Input.GetKey("left"))
        //{
        //    if (floorZAngle < 30f)
        //    {
        //        transform.Rotate(0f, 0f, 1f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.z > 0)
        //    {
        //        transform.Rotate(0, 0f, floorZAngle / -8f);
        //    }
        //}
        //if (Input.GetKey("right"))
        //{
        //    if (floorZAngle > -30f)
        //    {
        //        transform.Rotate(0f, 0f, -1f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.z > 0)
        //    {
        //        transform.Rotate(0f, 0f, -floorZAngle / 8f);
        //    }
        //}

        //スティック
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            if (floorXAngle < 30f)
            {
                transform.Rotate(1f, 0f, 0f);
            }
        }
        //else if (!Input.GetAxis("Horizontal"))
        //{
        //    if (transform.eulerAngles.x > 0)
        //    {
        //        transform.Rotate(floorXAngle / -8f, 0f, 0f);
        //    }
        //}
        //if (Input.GetKey("down"))
        //{
        //    if (floorXAngle > -30f)
        //    {
        //        transform.Rotate(-1f, 0f, 0f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.x > 0)
        //    {
        //        transform.Rotate(-floorXAngle / 8f, 0f, 0f);
        //    }
        //}

        //if (Input.GetKey("left"))
        //{
        //    if (floorZAngle < 30f)
        //    {
        //        transform.Rotate(0f, 0f, 1f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.z > 0)
        //    {
        //        transform.Rotate(0, 0f, floorZAngle / -8f);
        //    }
        //}
        //if (Input.GetKey("right"))
        //{
        //    if (floorZAngle > -30f)
        //    {
        //        transform.Rotate(0f, 0f, -1f);
        //    }
        //}
        //else if (!Input.anyKey)
        //{
        //    if (transform.eulerAngles.z > 0)
        //    {
        //        transform.Rotate(0f, 0f, -floorZAngle / 8f);
        //    }
        //}
    }
}
