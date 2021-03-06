﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform enemytransform;
    public float speed;
    public float timePatrol;
    public Vector2 direction;

    public bool flip;

    float timeCounter;

    void Start()
    {
        flip = false;
    }

    void Update()
    {
        timeCounter += Time.deltaTime;
        if (timeCounter >= timePatrol)
        {
            speed *= -1;
            timeCounter = 0;
        }

        enemytransform.Translate(0, direction.y * speed, 0, Space.World);
    }
}
