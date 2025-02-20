using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlareRotate : MonoBehaviour
{
    public float speed=10;
    void Start()
    {
        
    }

    // Update is calld once per 
    void Update()
    {
        Vector3 rot= transform.localEulerAngles;
        Vector3 pos = transform.position;
        pos.z = .1f;
        rot.z += speed * Time.deltaTime;
        transform.localEulerAngles = rot;
        transform.position = pos;
    }
}
