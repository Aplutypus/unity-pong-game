using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public InputAction movement;

    public float speed = 0f;
    float moveX = 0f;
    float moveY = 0f;

    void Start()
    {
        
    }
    void OnEnable()
    {
        movement.Enable();
    }

    void OnDisable()
    {
        movement.Disable();
    }

    void Update()
    {
        moveX = movement.ReadValue<Vector2>().x;
        moveY = movement.ReadValue<Vector2>().y;


        transform.position += new Vector3(moveX, 0, 0) * Time.deltaTime * speed;
    }
}
