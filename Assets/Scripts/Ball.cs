using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public InputAction start;
    bool gameStart = false;
    Rigidbody2D ballRigidbody;
    public bool clone;
    float BallVelocity = 8f;

    private void OnEnable()
    {
        start.Enable();
    }
    private void OnDisable()
    {
        start.Disable();    
    }

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        if (clone)
        {
            ballRigidbody.velocity = new Vector2(0f, -BallVelocity);
        }
    }

    void Update()
    {
        if (!clone)
        {
            if (!gameStart)
            {
                this.transform.position = new Vector3(0f, -2.75f, 0f);
                ballRigidbody.velocity = new Vector2(0f, 0f);
            }

            if (Convert.ToBoolean(start.ReadValue<float>()))
            {
                gameStart = true;
                ballRigidbody.velocity = new Vector2(0f, -BallVelocity);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        System.Random rngFloat = new System.Random();
        Vector2 randomVelocity = new Vector2(Convert.ToSingle(rngFloat.NextDouble()), Convert.ToSingle(rngFloat.NextDouble()));
        ballRigidbody.velocity += randomVelocity;
    }
}
