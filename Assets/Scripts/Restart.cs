using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CheckAmountOfBlocks()
    {
        GameObject[] blockObjects = GameObject.FindGameObjectsWithTag("Block");
        if (blockObjects.Length < 2)
        {
            RestartLevel();
        }
    }
}
