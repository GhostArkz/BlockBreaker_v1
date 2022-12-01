using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Paddle : MonoBehaviour
{
    public InputAction paddleControls;
    //public Paddle myPaddle;
    float paddleSpeed = 6f;
    Vector3 paddlePosition;
    float screenBorder;
    float paddleBorder;
    private void OnEnable()
    {
        paddleControls.Enable();
    }
    private void OnDisable()
    {
        paddleControls.Disable(); 
    }

    void Start()
    {
        paddlePosition = this.transform.position;
        Camera camera = Camera.main;
        screenBorder = camera.orthographicSize * Screen.width / Screen.height;
        paddleBorder = GetComponent<BoxCollider2D>().bounds.size.x * Screen.width / Screen.height;
        //myPaddle = this;
        //Debug.Log(camera.orthographicSize);    
        //Debug.Log(GetComponent<BoxCollider2D>().bounds.size.x);
    }
    void Update()
    {
        float xPositionPaddle = this.transform.position.x;
        xPositionPaddle += paddleControls.ReadValue<Vector2>().x * paddleSpeed * Time.deltaTime;
        paddlePosition.x = Mathf.Clamp(xPositionPaddle, -screenBorder + paddleBorder, screenBorder - paddleBorder);
        this.transform.position = paddlePosition;

    }



}
