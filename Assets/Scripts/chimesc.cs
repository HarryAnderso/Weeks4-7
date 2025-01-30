using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimesc : MonoBehaviour
{
    public AudioSource Ads;
    public AudioClip clips;
    public float t=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += (Time.deltaTime*10);
        transform.eulerAngles = rot;

        if(transform.eulerAngles.z>30*t)
        {
            Ads.PlayOneShot(clips);
            t = t + 1;
        }
        if(transform.eulerAngles.z>350)
        {
            t = 1;
        }
    }
}
