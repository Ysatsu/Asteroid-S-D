﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Satsuki Yamamoto
//Asteroids
//Math&Physics
//11/1/2018

public class ScreenWrapper : MonoBehaviour
{
    float colliderRadius;

    // Use this for initialization
    void Start ()
    {  
        colliderRadius = GetComponent<CircleCollider2D>().radius;
    }

    void OnBecameInvisible()

    {
        Vector2 position = transform.position;

        // check left, right, top, and bottom sides
        if (position.x + colliderRadius < ScreenUtils.ScreenLeft ||
            position.x - colliderRadius > ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }
        if (position.y - colliderRadius > ScreenUtils.ScreenTop ||
            position.y + colliderRadius < ScreenUtils.ScreenBottom)
        {
            position.y *= -1;
        }

        // move ship
        transform.position = position;
    }

}
