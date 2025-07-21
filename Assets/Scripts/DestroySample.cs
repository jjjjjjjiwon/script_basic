using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySample : MonoBehaviour
{
    public GameObject other;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //Destroy(gameObject); // 오브젝트 지우기
            //Destroy(other);   // 선택한 것을 지운다
            Destroy(other.GetComponent<MeshRenderer>()); // 렌더링을 지운다
        }
    }
}
