using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    GameObject CenterEyeAnchor;
    // Start is called before the first frame update
    void Start()
    {
        CenterEyeAnchor = GameObject.Find("CenterEyeAnchor");
    }

    // Update is called once per frame
    

    private void LateUpdate()
    {
        Vector3 headAngle = CenterEyeAnchor.transform.localEulerAngles;
        float head_angle_y = headAngle.y;

        Transform myTransform = this.transform;

        // ローカル座標を基準に、回転を取得
        Vector3 localAngle = myTransform.localEulerAngles; ;
        localAngle.y = head_angle_y;

        myTransform.localEulerAngles = localAngle;
    }
}
