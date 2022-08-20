using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float minClamp;
    public float maxClamp;
    public KeyCode upKey;
    public KeyCode downKey;

    void Update()
    {
        Vector3 position = transform.position;

        if (Input.GetKey(upKey))
        {
            position.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(downKey))
        {
            position.y -= speed * Time.deltaTime;
        }
        
        position.y = Mathf.Clamp(position.y, minClamp, maxClamp);

        transform.position = position;
    }
}
