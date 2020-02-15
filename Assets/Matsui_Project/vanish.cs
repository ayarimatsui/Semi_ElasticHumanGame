using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish : MonoBehaviour
{
    GameObject button1;　//button1を入れる変数
    public GameObject lasers;
    public GameObject particleObject1;
    public GameObject particleObject2;
    private Switch_Flag switch_Flag;　//Switch_Flagを参照する変数
    private bool is_Open;
    public GameObject CongratsText;
    // Start is called before the first frame update
    void Start()
    {
        //button1の情報を取得
        button1 = GameObject.Find("button1");
        lasers = GameObject.Find("lasers");
        //button1のSwitch_Flagを取得
        switch_Flag = button1.GetComponent<Switch_Flag>();
        is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        CongratsText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!is_Open)
        {
            is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        }
        //is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得

        if (is_Open)
        {
            this.gameObject.SetActive(false);
            CongratsText.SetActive(true);
            Instantiate(particleObject1, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Instantiate(particleObject2, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            //lasers.SetActive(false);
        }
    }
}
