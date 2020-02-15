using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_hand : MonoBehaviour
{
    public GameObject RHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 RHandAngle = RHand.transform.localEulerAngles;
        float hand_angle_x = RHandAngle.x;
        float hand_angle_y = RHandAngle.y;
        float hand_angle_z = RHandAngle.z;

        Transform myTransform = this.transform;

        // ローカル座標を基準に、回転を取得
        Vector3 localAngle = myTransform.localEulerAngles; ;
        localAngle.x = RHandAngle.x;
        //.y = RHandAngle.y;
        //localAngle.z = RHandAngle.z;

        myTransform.localEulerAngles = localAngle;
    }
}
