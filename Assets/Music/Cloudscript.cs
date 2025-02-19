using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudscript : MonoBehaviour
{
    public float cspeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += cspeed * Time.deltaTime;
        transform.position = pos;
        Vector2 screenpos = Camera.main.WorldToScreenPoint(pos);

        if(screenpos.x < 0 || screenpos.x >Screen.width)
        {
            cspeed = cspeed * -1;
        }

    }
}
