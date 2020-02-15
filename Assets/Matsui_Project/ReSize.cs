using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSize : MonoBehaviour
{
    private Vector3 originalLocalScale;//originalTransform.localScale;
    private Vector3 current_scale;
    private Vector3 OriginalEmptyScale;
    private Vector3 EmptyScale;
    private int frame;
    private GameObject elastic_part;
    private GameObject empty;
    // Start is called before the first frame update
    void Start()
    {
        originalLocalScale = transform.localScale;
        elastic_part = transform.parent.gameObject;
        empty = elastic_part.transform.parent.gameObject;
        //OriginalEmptyScale = empty.transform.lossyScale;
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (frame % 5 == 0)
        {
            EmptyScale = empty.transform.lossyScale;
            transform.localScale = new Vector3(originalLocalScale.x / EmptyScale.y, originalLocalScale.y / EmptyScale.x, originalLocalScale.z / EmptyScale.z);
        }
        frame += 1;
    }
}
