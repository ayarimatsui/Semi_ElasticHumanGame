using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1_Up : MonoBehaviour
{
    GameObject button4;　//button1を入れる変数
    private Switch_Flag4 switch_Flag4;　//Switch_Flagを参照する変数
    private bool is_button1;

    private void Start()
    {
        //button1の情報を取得
        button4 = GameObject.Find("button4");
        //button1のSwitch_Flagを取得
        switch_Flag4 = button4.GetComponent<Switch_Flag4>();

        is_button1 = switch_Flag4.is_button1; //Switch_Flagからis_Openを取得
        Debug.Log(is_button1);
    }

    void Update()
    {
        if (!is_button1)
        {
            is_button1 = switch_Flag4.is_button1; //Switch_Flagからis_Openを取得
        }
        //is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        Debug.Log(is_button1);
        if (is_button1)
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
