using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MouseMove : MonoBehaviour
{
    private float _xAxisRotation;
    private float _yAxisRotation;
    private float _xCurrentRotation;
    private float _yCurrentRotation;
    public Camera camera;
    public GameObject player;
    public float sensivity = 5f;
    private float smoothTime = 0.1f;
    private float _currentVelocityX;
    private float _currentVelocityY;
    

    private void Update()
    {
        MouseMove();
    }

    private void MouseMove()
    {
        _xAxisRotation += Input.GetAxis("Mouse X") * sensivity;
        _yAxisRotation += Input.GetAxis("Mouse Y") * sensivity;

        _xCurrentRotation = Mathf.SmoothDamp(_xAxisRotation, _xCurrentRotation, ref _currentVelocityX, smoothTime);
        _yCurrentRotation = Mathf.SmoothDamp(_yAxisRotation, _yCurrentRotation, ref _currentVelocityY, smoothTime);
        
        camera.transform.rotation = Quaternion.Euler(-_yCurrentRotation, _xCurrentRotation, 0f);
        player.transform.rotation = Quaternion.Euler(0f, _xAxisRotation, 0f);
    }
}
