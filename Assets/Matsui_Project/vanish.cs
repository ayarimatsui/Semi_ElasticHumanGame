using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish : MonoBehaviour
{
    GameObject button1;　//button1を入れる変数
    //public GameObject lasers;
    public GameObject particleObject1;
    public GameObject particleObject2;
    public GameObject particleObject_GameOver;
    public GameObject GameOverPlace;
    private Switch_Flag switch_Flag;　//Switch_Flagを参照する変数
    private bool is_Open;
    public GameObject CongratsText;
    public GameObject GameOverText;
    public int touch;
    GameObject lasertraps;
    // Start is called before the first frame update
    void Start()
    {
        //button1の情報を取得
        button1 = GameObject.Find("button1");
        //lasers = GameObject.Find("lasers");
        lasertraps = GameObject.Find("lasertraps");
        //button1のSwitch_Flagを取得
        switch_Flag = button1.GetComponent<Switch_Flag>();
        is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        CongratsText.SetActive(false);
        GameOverText.SetActive(false);
        touch = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!is_Open)
        {
            is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得
        }
        //is_Open = switch_Flag.is_Open; //Switch_Flagからis_Openを取得

        if (!is_Open && touch>=6)
        {
          Instantiate(particleObject_GameOver, GameOverPlace.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
          GameOverText.SetActive(false);
          GetComponent<ElasticArm>().enabled = false;
        }

        if (is_Open)
        {
            this.gameObject.SetActive(false);
            lasertraps.SetActive(false);
            CongratsText.SetActive(true);
            Instantiate(particleObject1, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            Instantiate(particleObject2, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
            //lasers.SetActive(false);
        }
    }
}
