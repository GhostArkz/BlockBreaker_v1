using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    Restart restart;
    void Start()
    {
        restart = FindObjectOfType<Restart>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        GameObject[] ballObjects = GameObject.FindGameObjectsWithTag("Ball");

        if (ballObjects.Length < 2)
        {
            restart.RestartLevel();
        }
        else
        {
            Destroy(trigger.gameObject);
        }
    }
}
