using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    // 라이트 끄기
    private Light myLight;
    void Start()
    {
        // myLight.enabled = true; // 연결하기 전이라 에러난다
        myLight = GetComponent<Light>();
        myLight.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;    
        }
    }
    



}
