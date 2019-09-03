﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 150;
    public string Axis;
    void FixedUpdate()
    {
        // Get Horizontal Input
        float h = Input.GetAxisRaw("Horizontal");

        // Set Velocity (movement direction * speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
