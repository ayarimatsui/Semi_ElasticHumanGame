using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class door : MonoBehaviour {
	GameObject thedoor;
    GameObject button1;
    private Switch_Flag switch_Flag;
    private bool is_Open;
    private int frame;

    private void Start()
    {
        button1 = GameObject.Find("button1");
        switch_Flag = button1.GetComponent<Switch_Flag>();

        is_Open = switch_Flag.is_Open;
        Debug.Log(is_Open);
        frame = 0;
    }

    void Update()
    {
        if (!is_Open)
        {
            is_Open = switch_Flag.is_Open;
        }
        Debug.Log(is_Open);
        if (is_Open)
        {
            frame += 1;
            if (transform.localPosition.y<=5)
            {
                transform.localPosition = new Vector3(0, (float)(frame * 0.03), 0);
            }
            //thedoor = GameObject.FindWithTag("door");
            //thedoor.GetComponent<Animation>().Play("open");
        }
     }

    //void OnSwitchExit ( Collider obj  ){
	    //thedoor= GameObject.FindWithTag("SF_Door");
	    //thedoor.GetComponent<Animation>().Play("close");
    //}
}
