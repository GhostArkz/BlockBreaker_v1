using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class EnlargePaddleBlock : MonoBehaviour
{
    private Vector3 scaleChange;
    void Start()
    {
        scaleChange = new Vector3(.1f, 0, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject myPaddle = GameObject.Find("Paddle");
        Transform paddle = myPaddle.GetComponent<Transform>();
        paddle.localScale += scaleChange;
    }
}
