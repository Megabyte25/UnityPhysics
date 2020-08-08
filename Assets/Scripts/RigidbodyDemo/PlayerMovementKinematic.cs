using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementKinematic : MonoBehaviour
{
    public float speed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = Vector3.ClampMagnitude(new Vector3(horizontal, 0f, vertical), 1f);

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
