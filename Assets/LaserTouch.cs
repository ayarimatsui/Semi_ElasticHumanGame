using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTouch : MonoBehaviour
{
  public GameObject particleObject;
  private GameObject particlePlace;
  //どちらかのIs TriggerがオンになっているCollider同士が接触すると呼び出し
  private void OnTriggerEnter(Collider obj)
  {
      Debug.Log("touched Laser0");
      particlePlace = transform.parent.gameObject;
      Instantiate(particleObject, particlePlace.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
  }
}
