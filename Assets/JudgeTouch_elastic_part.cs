using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeTouch_elastic_part : MonoBehaviour
{
    public AudioClip audioClip_lasers;
    OVRHapticsClip hapticsClip_lasers;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        hapticsClip_lasers = new OVRHapticsClip(audioClip_lasers);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Lasers")
        {
            OVRHaptics.RightChannel.Mix(hapticsClip_lasers);
            audioSource.PlayOneShot(audioClip_lasers);
        }
    }
}
