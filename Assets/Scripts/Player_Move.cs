using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float movementSpeed;
    private float _xAxisMovement;
    private float _zAxisMovement;

    private CharacterController _player;
    private Vector3 _movementDirection;

    private void Start()
    {
        _player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _xAxisMovement = Input.GetAxis("Horizontal");
        _zAxisMovement = Input.GetAxis("Vertical");
        
        if (_player.isGrounded)
        {
            _movementDirection = new Vector3(_xAxisMovement, 0f, _zAxisMovement);
            _movementDirection = transform.TransformDirection(_movementDirection);
        }

        _movementDirection.y -= 1;
        _player.Move(_movementDirection * (movementSpeed * Time.deltaTime));
    }
}
