using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minPosX = 1f;
    [SerializeField] float maxPosX = 15f;

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y)
        {
            x = Mathf.Clamp(Input.mousePosition.x / Screen.width * screenWidthInUnits, minPosX, maxPosX)
        };
        transform.position = paddlePos; 
    }
}
