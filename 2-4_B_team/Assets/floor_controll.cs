using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_controll : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 1f));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Rotate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Rotate(-1, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) ||
            Input.GetKeyUp(KeyCode.RightArrow) ||
            Input.GetKeyUp(KeyCode.DownArrow) ||
            Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
