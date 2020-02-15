using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingElasticArm : MonoBehaviour
{
    public Vector3 scale;
    public Vector3 position;
    public Vector3 rotation;
    //public Transform originalTransform = this.transform;
    private Vector3 originalLocalScale;//originalTransform.localScale;
    private Vector3 originalLocalPosition;
    private Vector3 originalLocalRotation;
    private Vector3 current_scale;
    private Vector3 current_position;
    private Vector3 current_rotation;
    private int frame;
    private float current;

    // Start is called before the first frame update
    void Start()
    {
        originalLocalScale = transform.localScale;
        current_scale = transform.localScale;
        originalLocalPosition = transform.localPosition;
        current_position = transform.localPosition;
        originalLocalRotation = transform.localEulerAngles;
        current_rotation = transform.localEulerAngles;
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (current_scale.x <= scale.x)
            {
                //total_time += Time.deltaTime;
                if (frame % 5 == 0)
                {
                    current = current_scale.x/scale.x;//Mathf.Abs((current_scale.x - originalLocalScale.x) / (scale.x - originalLocalScale.x));
                    transform.localScale = new Vector3(originalLocalScale.x+(scale.x-originalLocalScale.x) * Mathf.Sin((float)(Mathf.PI / 2.0) * current), current_scale.y, current_scale.z);
                    transform.localPosition = new Vector3(originalLocalPosition.x+(position.x-originalLocalPosition.x)* Mathf.Sin((float)(Mathf.PI / 2.0) * current), originalLocalPosition.y+(position.y-originalLocalPosition.y) * Mathf.Sin((float)(Mathf.PI / 2.0) * current), originalLocalPosition.z+(position.z-originalLocalPosition.z) * Mathf.Sin((float)(Mathf.PI / 2.0) * current));
                    transform.localEulerAngles = new Vector3(originalLocalRotation.x+(rotation.x-originalLocalRotation.x) * current, originalLocalRotation.y+(rotation.y-originalLocalRotation.y) * current, originalLocalRotation.z+(rotation.z-originalLocalRotation.z) * current);
                    //transform.Rotate((rotation.x-current_rotation.x)/100, (rotation.y - current_rotation.y) / 100, (rotation.z - current_rotation.z) / 100);
                }
                //transform.localScale = new Vector3(scale.x*Mathf.Sin((float)(Mathf.PI/2.0)*current_scale.x/scale.x), 0, 0); //new Vector3((float)1.0 / (total_time * Mathf.Sqrt(scale.x)), 0, 0);//new Vector3(Mathf.Sqrt(scale.x) * Time.deltaTime, 0, 0);//new Vector3(1 * Mathf.Log(Time.deltaTime, Time.deltaTime/1000), 0, 0);
                current_scale = transform.localScale;
                current_position = transform.localPosition;
                current_rotation = transform.localEulerAngles;
                frame += 1;
            }
        }

        else
        {
            //total_time = 0;
            frame = 0;
            transform.localScale = new Vector3(originalLocalScale.x, originalLocalScale.y, originalLocalScale.z);
            transform.localPosition = new Vector3(originalLocalPosition.x, originalLocalPosition.y, originalLocalPosition.z);
            transform.localEulerAngles = new Vector3(originalLocalRotation.x, originalLocalRotation.y, originalLocalRotation.z);
            current_scale = transform.localScale;
            current_position = transform.localPosition;
            current_rotation = transform.localEulerAngles;
        }

    }
}
