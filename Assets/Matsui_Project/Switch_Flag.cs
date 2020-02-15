using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Flag : MonoBehaviour
{
    public bool is_Open; //ドアが開いたかどうかの変数
    //public KeyCode keyCode;　//どのキーを入力するかの変数

    //どちらかのIs TriggerがオンになっているCollider同士が接触すると呼び出し
    private void OnTriggerEnter(Collider obj)
    {
        Debug.Log("pushed");
        //is_Openがfalseの時is_Openをtrueにする
        if (!is_Open) is_Open = true;
        //if (Input.GetKey(keyCode) && !is_Open) is_Open = true;
    }

}
