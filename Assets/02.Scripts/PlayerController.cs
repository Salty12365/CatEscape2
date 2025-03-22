using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public Vector3 pos;

    public float minPosition_X;
    public float maxPosition_X;

    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.position.x >= -8)
            {
                transform.Translate(-0.1f, 0, 0);
            }
            
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x >= 8)
            {
                transform.Translate(0.1f, 0, 0);
            }
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minPosition_X, maxPosition_X), pos.y, pos.z);
    }
}
