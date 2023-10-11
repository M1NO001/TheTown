using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpartaTownMovement : MonoBehaviour
{
    private SpartaTownController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    public Animator anim;

    private void Awake()
    {
        _controller = GetComponent<SpartaTownController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        if (_rigidbody.velocity == Vector2.zero)
        {
            anim.SetBool("isMoving", false);
        }
        else
        {
            anim.SetBool("isMoving", true);
        }
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }
}
