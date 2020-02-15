using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private int frame;
    // Start is called before the first frame update
    void Start()
    {
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) & (frame <= 90))
        {
            frame += 1;
            transform.localEulerAngles += new Vector3(0, 1 ,0);
        }
    }
}
