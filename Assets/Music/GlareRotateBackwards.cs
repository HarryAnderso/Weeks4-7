using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlareRotateBackwards : MonoBehaviour
{
    public float rspeed = -7;
    void Start()
    {
        
    }

    // testing
    void Update()
    {
        Vector3 rot = transform.localEulerAngles;
        Vector3 pos = transform.position;
        pos.z = .1f;
        rot.z += rspeed * Time.deltaTime;
        transform.localEulerAngles = rot;
        transform.position = pos;
    }
}
