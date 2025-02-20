using UnityEngine;
using System.Collections;

public class NewMonoBehaviour : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {

    }

    // Update is  once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(prefab);
        }
    }
}
