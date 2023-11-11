using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MovementBehaviour : MonoBehaviour
{
    public LayerMask wallLayer;
    //public Transform wall;
    private Rigidbody2D _body;
    [SerializeField] private int speed;

    public bool isPressed;
    public bool isTouch;
    private float _acceleration;

    private void Awake()
    {
        _body = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        float targetSpeed = speed * _acceleration;
        _body.velocity = new Vector2(targetSpeed, _body.velocity.y);
        //isTouch = Physics2D.OverlapCapsule(wall.position, new Vector2(0f, -1f), CapsuleDirection2D.Horizontal, 0, wallLayer);

    }

    public void Move(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            isPressed = true;
            _acceleration = 1;
        } 
        else if (value.canceled)
        {
            isPressed = false;
            _acceleration = 0;
        }
    }
}
