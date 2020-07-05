using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // config params
    [SerializeField] Paddle paddleOne;
    [SerializeField] float posX = 2f;
    [SerializeField] float posY = 15f;

    // state
    Vector2 paddleToBallVector;
    bool hasStarted;
    // Start is called before the first frame update
    void Start()
    {
        hasStarted = false;
        paddleToBallVector = transform.position - paddleOne.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockToBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(posX, posY);
           
        }
    }

    private void LockToBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddleOne.transform.position.x, paddleOne.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
