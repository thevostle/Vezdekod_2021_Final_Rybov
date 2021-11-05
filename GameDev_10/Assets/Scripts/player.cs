using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    private float health;
    private float speed;

    private float moveInputX;
    private float moveInputY;

    private stats stats;
    private Rigidbody2D rb;

    public Joystick joystick;

    public RuntimeAnimatorController[] views;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        stats = FindObjectOfType<stats>();
        health = stats.HealthMax;
        speed = stats.Speed;
    }

    void Update()
    {
        moveInputX = joystick.Horizontal;
        moveInputY = joystick.Vertical;

        rb.velocity = new Vector2(moveInputX * speed, moveInputY * speed);

        GetComponent<Animator>().runtimeAnimatorController = views[0];
        if (Math.Abs(moveInputY) > moveInputX && moveInputY != 0)
        {
            if (moveInputY > 0)
            {
                GetComponent<Animator>().runtimeAnimatorController = views[1];
            }
            else
            {
                GetComponent<Animator>().runtimeAnimatorController = views[2];
            }
        }

        if (moveInputX >= 0)
            GetComponent<SpriteRenderer>().flipX = true;
        else
            GetComponent<SpriteRenderer>().flipX = false;
    }
}
