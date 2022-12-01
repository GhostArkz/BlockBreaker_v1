using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Restart restart;

    private void Start()
    {
        restart = FindObjectOfType<Restart>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        handleCollision();
    }
    void handleCollision()
    {
        restart.CheckAmountOfBlocks();
        Destroy(this.gameObject);
    }
}
