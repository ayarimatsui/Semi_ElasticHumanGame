using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button4_Up : MonoBehaviour
{
    GameObject button3;　//button1を入れる変数
    private Switch_Flag3 switch_Flag3;　//Switch_Flagを参照する変数
    private bool is_button4;

    private void Start()
    {
        //button1の情報を取得
        button3 = GameObject.Find("button3");
        //button1のSwitch_Flagを取得
        switch_Flag3 = button3.GetComponent<Switch_Flag3>();

        is_button4 = switch_Flag3.is_button4; //Switch_Flagからis_Openを取得
        Debug.Log(is_button4);
    }

    void Update()
    {
        if (!is_button4)
        {
            is_button4 = switch_Flag3.is_button4; //Switch_Flagからis_Openを取得
        }
        //is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        Debug.Log(is_button4);
        if (is_button4)
        {
            if (transform.localPosition.y <= -1.216)
            {
                transform.localPosition += new Vector3(0, (float)0.03, 0);
            }
            //thedoor = GameObject.FindWithTag("door");
            //thedoor.GetComponent<Animation>().Play("open");
        }
    }
}
