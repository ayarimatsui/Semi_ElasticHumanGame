using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Flag4 : MonoBehaviour
{
    public bool is_button1; //ボタンが押されたかどうかの変数
    public GameObject Button4Text;
    //public KeyCode keyCode;　//どのキーを入力するかの変数

    //どちらかのIs TriggerがオンになっているCollider同士が接触すると呼び出し
    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("pushed");
        Button4Text.SetActive(true);
        //is_Openがfalseの時is_Openをtrueにする
        if (!is_button1) is_button1 = true;
        //if (Input.GetKey(keyCode) && !is_Open) is_Open = true;
    }
}
