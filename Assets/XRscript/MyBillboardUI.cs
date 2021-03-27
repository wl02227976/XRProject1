using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBillboardUI : MonoBehaviour
{
    public Camera m_Camera;
    void LateUpdate()
    {
        transform.forward = m_Camera.transform.forward;
    }
}
