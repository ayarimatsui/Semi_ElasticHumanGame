using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((OVRInput.Get(OVRInput.RawButton.RIndexTrigger) && OVRInput.Get(OVRInput.RawButton.LIndexTrigger)) || Input.GetKeyDown("space"))
        {
          SceneManager.LoadScene("ElasticHuman_Game");
        }
    }
}
