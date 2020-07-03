using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Camera : MonoBehaviour
{
    public GameObject ball;
    Vector3 Distance;
    void Start()
    {
        Distance = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + Distance;
    }
}
