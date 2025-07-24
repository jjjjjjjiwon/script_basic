using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSample : MonoBehaviour
{
    public Light light;
    void Start()
    {
        Vector3 from = new Vector3(1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);
        Vector3 result = Vector3.Lerp(from, to, 0.75f); // Lerp - 두개의 값의 n%중간값을 반환 
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
    }
}
