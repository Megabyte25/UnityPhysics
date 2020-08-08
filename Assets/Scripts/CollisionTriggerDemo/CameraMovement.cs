using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;
    public float speedMultiplier;

    void Update()
    {
        bool isSpeedBoost = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

        Vector3 direction = Vector3.zero;
        // Forward and backward
        if (Input.GetKey(KeyCode.W))
        {
            direction.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z -= 1;
        }

        // Left and right
        if (Input.GetKey(KeyCode.A))
        {
            direction.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x += 1;
        }

        // Up and down
        if (Input.GetKey(KeyCode.Q))
        {
            direction.y -= 1;
        }
        if (Input.GetKey(KeyCode.E))
        {
            direction.y += 1;
        }

        float moveSpeed = isSpeedBoost ? speed * speedMultiplier : speed;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
