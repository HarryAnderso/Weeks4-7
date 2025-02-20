using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudscript : MonoBehaviour
{
    public float cspeed = 5;
    public float life = 1;
    public void Start()
    {
        Destroy(gameObject, 5);
        Vector3 pos = transform.position;


        //cspeed = Random.Range(-5, 5);
        pos.y = Random.Range(0, 4);
        transform.position = pos;
    }

    // Update is   per frame
    public void Update()
    {
        
        Vector3 pos = transform.position;
        pos.x += cspeed * Time.deltaTime;
        
        Vector2 screenpos = Camera.main.WorldToScreenPoint(pos);

        if(screenpos.x < 0 || screenpos.x >Screen.width)
        {
            cspeed = cspeed * -1;
        }

        life -= Time.deltaTime;

        Vector3 sc = transform.localScale;
        sc.x = life/5;
        sc.y = life/5;
        transform.localScale = sc;
        pos.y +=life/50000;
        transform.position = pos;
    }
    public void speedset(float speedf)
    {
        cspeed = speedf;
    }
}
