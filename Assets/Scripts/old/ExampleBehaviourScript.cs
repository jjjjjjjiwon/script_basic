using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviourScript : MonoBehaviour
{
    Renderer myRenderer;
    Color mycolor;
    // 색깔 바꾸기

    void Start()
    {
        mycolor = GetComponent<Renderer>().material.color;
        myRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // myRenderer.material.color = Color.red;
            mycolor = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            // myRenderer.material.color = Color.green;
            mycolor = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            // myRenderer.material.color = Color.blue;
            mycolor = Color.blue;
        }

        myRenderer.material.color = mycolor;
    }
}
