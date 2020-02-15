using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeTouch : MonoBehaviour
{
  public bool stop_elastic_arm;
  public AudioClip audioClip_button;
  OVRHapticsClip hapticsClip_button;
  //public AudioClip audioClip_walls;
  //OVRHapticsClip hapticsClip_walls;
  public AudioClip audioClip_lasers;
  OVRHapticsClip hapticsClip_lasers;
  AudioSource audioSource;
  //どちらかのIs TriggerがオンになっているCollider同士が接触すると呼び出し
  void Start()
  {
    stop_elastic_arm = false;
    hapticsClip_button = new OVRHapticsClip(audioClip_button);
    //hapticsClip_walls = new OVRHapticsClip(audioClip_walls);
    hapticsClip_lasers = new OVRHapticsClip(audioClip_lasers);
    audioSource = GetComponent<AudioSource>();
  }

  private void OnTriggerEnter(Collider obj)
  {
    if (obj.gameObject.tag == "button1" | obj.gameObject.tag == "button2" | obj.gameObject.tag == "button3" | obj.gameObject.tag == "button4")
    {
      stop_elastic_arm = true;
      OVRHaptics.RightChannel.Mix(hapticsClip_button);
      audioSource.PlayOneShot(audioClip_button);
　　}
    /*if (obj.gameObject.tag == "Walls")
    {
      stop_elastic_arm = true;
      OVRHaptics.RightChannel.Mix(hapticsClip_walls);
      audioSource.PlayOneShot(audioClip_walls);
　　}*/
    if (obj.gameObject.tag == "Lasers")
    {
      OVRHaptics.RightChannel.Mix(hapticsClip_lasers);
      audioSource.PlayOneShot(audioClip_lasers);
　　}
  }

  private void OnTriggerExit(Collider obj)
  {
    stop_elastic_arm = false;
  }
}
