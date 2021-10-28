using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRotation : MonoBehaviour
{
    Rigidbody rb;
    Vector3 torque;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // 重力を無効にする
    }

    void FixedUpdate()
    {
        //Vector3 angles = transform.eulerAngles;

        //if (angles.z > 180)
        //{
        //    // デフォルトでは角度は0～360なので-180～180となるように補正
        //    angles.z = angles.z - 360;
        //}
        //if (angles.x > 180)
        //{
        //    // デフォルトでは角度は0～360なので-180～180となるように補正
        //    angles.x = angles.x - 360;
        //}

        //// 入力がなければトルクを0にする
        //torque = Vector3.zero;

        //if (Input.GetAxis("Vertical") > 0)//
        //{
        //    if (angles.x < 30f)//
        //    {
        //        torque = Vector3.right;
        //    }
        //}
        //else if (Input.GetAxis("Vertical") < 0)
        //{
        //    if (angles.x > -30f)
        //    {
        //        torque = Vector3.left;
        //    }
        //}
        //else
        //{
        //    if (angles.x > 0 || angles.x < 0)
        //    {
        //        torque = Vector3.zero;
        //    }
        //}
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //    if (angles.z > -30f)
        //    {
        //        torque = Vector3.back;
        //    }
        //    else if (Input.GetAxis("Horizontal") > 0)
        //    {
        //        if (angles.z < 30f)
        //        {
        //            torque = Vector3.forward;
        //        }
        //    }
        //    else
        //    {
        //        if (angles.z > 0 || angles.z < 0)
        //        {
        //            torque = Vector3.zero;
        //        }
        //    }
        //}

        //// 現在の角速度
        //print(rb.angularVelocity);

        //// トルクを加える
        //rb.AddTorque(torque, ForceMode.Acceleration);

        // 加える位置を帰る場合
        // rb.AddForceAtPosition(torque, ForceMode.Acceleration, transform.position);

        //// 左右キーの入力を取得
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //// 現在のGameObjectのY軸方向の角度を取得
        //float floorZAngle = transform.eulerAngles.z;
        //float floorXAngle = transform.eulerAngles.x;


        //// 現在の角度が180より大きい場合
        //if (floorZAngle > 180)
        //{
        //    // デフォルトでは角度は0～360なので-180～180となるように補正
        //    floorZAngle = floorZAngle - 360;
        //}
        //if (floorXAngle > 180)
        //{
        //    // デフォルトでは角度は0～360なので-180～180となるように補正
        //    floorXAngle = floorXAngle - 360;
        //}

        ///**************************************/
        ////test1 加速

        //if (Input.GetAxis("Vertical") > 0)
        //{

        //    if (floorXAngle < 30f)
        //    {
        //        torque = Vector3.right;
        //        //transform.Rotate(vertical, 0f, 0f);
        //    }

        //}
        //else if (Input.GetAxis("Vertical") < 0)
        //{
        //    torque = Vector3.left;
        //    if (floorXAngle > -30f)
        //    {
        //        //transform.Rotate(vertical, 0f, 0f);
        //    }
        //}
        //else
        //{
        //    if (floorXAngle > 0 || floorXAngle < 0)
        //    {
        //        transform.Rotate(floorXAngle / -18f, 0f, 0f);
        //    }
        //}
        //// 現在の角速度
        //print(rb.angularVelocity);

        //// トルクを加える
        //rb.AddTorque(torque, ForceMode.Acceleration);

        /********************************************/
    }
}