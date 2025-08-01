using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    Rigidbody rb;   // 물리 법칙

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        rb.AddForce(transform.up * 500f);
        rb.useGravity = true;       // 중력 사용
    } 
}
