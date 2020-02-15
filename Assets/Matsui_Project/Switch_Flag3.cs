using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Flag3 : MonoBehaviour
{
    public bool is_button4; //ボタンが押されたかどうかの変数
    public GameObject Button3Text;
    //public KeyCode keyCode;　//どのキーを入力するかの変数

    //どちらかのIs TriggerがオンになっているCollider同士が接触すると呼び出し
    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("pushed");
        Button3Text.SetActive(true);
        //is_Openがfalseの時is_Openをtrueにする
        if (!is_button4) is_button4 = true;
        //if (Input.GetKey(keyCode) && !is_Open) is_Open = true;
    }
}
