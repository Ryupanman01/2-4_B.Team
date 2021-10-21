using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int pause;
    [SerializeField]GameObject PausePanel;
    /*
    public Text textPause;
    public Text textReStart;
    public Text textTitleBack;
    public Text textGameEnd;
    */

    void Start()
    {
        PausePanel.SetActive(false);
        /*
        textPause.enabled = false;
        textReStart.enabled = false;
        textTitleBack.enabled = false;
        textGameEnd.enabled = false;
*/
        pause = 0;
    }


    void Update()
    {
        if (Input.GetKeyDown("joystick button 7"))
        {
            if (pause==0)
            {
                PausePanel.SetActive(true);
                pause = 1;
                /*
                textPause.enabled = true;
                textReStart.enabled = true;
                textTitleBack.enabled = true;
                textGameEnd.enabled = true;
                */
            }
            else
            {
                PausePanel.SetActive(false);
                pause = 0;
                /*
                textPause.enabled = false;
                textReStart.enabled = false;
                textTitleBack.enabled = false;
                textGameEnd.enabled = false;
                */
            }
        }
    }
}
    
