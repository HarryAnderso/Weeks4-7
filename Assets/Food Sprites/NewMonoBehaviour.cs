using UnityEngine;
using System.Collections;

public class NewMonoBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public void Start()
    {

    }

    // Update is  once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab);
        }
    }
}
