using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Vector3 m_SpeedRotation;

    void Update()
    {
        transform.Rotate(m_SpeedRotation * Time.deltaTime);
    }
}
