using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiFixedHeadTarget : MonoBehaviour
{
    public Transform _target;
    public Vector3 _defaultPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(_defaultPosition.x, _target.position.y, _defaultPosition.z);
    }
}
