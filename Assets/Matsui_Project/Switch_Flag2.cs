using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Flag2 : MonoBehaviour
{
    public bool is_button3; //ボタンが押されたかどうかの変数
    public GameObject Button2Text;
    //public KeyCode keyCode;　//どのキーを入力するかの変数

    //どちらかのIs TriggerがオンになっているCollider同士が接触すると呼び出し
    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("pushed");
        Button2Text.SetActive(true);
        //is_Openがfalseの時is_Openをtrueにする
        if (!is_button3) is_button3 = true;
        //if (Input.GetKey(keyCode) && !is_Open) is_Open = true;
    }
}
