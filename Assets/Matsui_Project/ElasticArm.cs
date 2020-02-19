using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElasticArm : MonoBehaviour
{
    //public Vector3 scale;
    private Vector3 originalLocalScale;//originalTransform.localScale;
    private Vector3 current_scale;
    private int frame;
    public bool stop_elastic_arm;

    void Start()
    {
        originalLocalScale = transform.localScale;
        current_scale = transform.localScale;
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
      if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
      {
        Debug.Log("the trigger is being pushed");
        if (!stop_elastic_arm)
        {
          if (frame % 5 == 0)
          {
              transform.localScale = new Vector3(current_scale.x * (float)1.15, current_scale.y, current_scale.z);
          }
          //transform.localScale = new Vector3(scale.x*Mathf.Sin((float)(Mathf.PI/2.0)*current_scale.x/scale.x), 0, 0); //new Vector3((float)1.0 / (total_time * Mathf.Sqrt(scale.x)), 0, 0);//new Vector3(Mathf.Sqrt(scale.x) * Time.deltaTime, 0, 0);//new Vector3(1 * Mathf.Log(Time.deltaTime, Time.deltaTime/1000), 0, 0);
          current_scale = transform.localScale;
          frame += 1;
        }
        else
        {
          transform.localScale = current_scale;
        }
      }
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            if (current_scale.y <= scale.y)
            {
                //total_time += Time.deltaTime;
                if (frame % 5 == 0)
                {
                    transform.localScale = new Vector3(scale.x * Mathf.Sin((float)(Mathf.PI / 2.0) * current_scale.x / scale.x), current_scale.y, current_scale.z);
                }
                //transform.localScale = new Vector3(scale.x*Mathf.Sin((float)(Mathf.PI/2.0)*current_scale.x/scale.x), 0, 0); //new Vector3((float)1.0 / (total_time * Mathf.Sqrt(scale.x)), 0, 0);//new Vector3(Mathf.Sqrt(scale.x) * Time.deltaTime, 0, 0);//new Vector3(1 * Mathf.Log(Time.deltaTime, Time.deltaTime/1000), 0, 0);
                current_scale = transform.localScale;
                frame += 1;
            }
        }*/

        else
        {
            //total_time = 0;
            frame = 0;
            transform.localScale = new Vector3(originalLocalScale.x, originalLocalScale.y, originalLocalScale.z);
            current_scale = transform.localScale;
        }

    }
}
