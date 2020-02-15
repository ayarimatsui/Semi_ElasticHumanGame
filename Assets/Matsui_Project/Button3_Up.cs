using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3_Up : MonoBehaviour
{
    GameObject button2;　//button1を入れる変数
    private Switch_Flag2 switch_Flag2;　//Switch_Flagを参照する変数
    private bool is_button3;

    private void Start()
    {
        //button1の情報を取得
        button2 = GameObject.Find("button2");
        //button1のSwitch_Flagを取得
        switch_Flag2 = button2.GetComponent<Switch_Flag2>();

        is_button3 = switch_Flag2.is_button3; //Switch_Flagからis_Openを取得
        Debug.Log(is_button3);
    }

    void Update()
    {
        if (!is_button3)
        {
            is_button3 = switch_Flag2.is_button3; //Switch_Flagからis_Openを取得
        }
        //is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        Debug.Log(is_button3);
        if (is_button3)
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
