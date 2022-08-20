using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolinha : MonoBehaviour
{
    public float speed;
    private bool _trocou;
    private float _yRandom = 0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _trocou = !_trocou;

        if(speed <= 17f) speed += 0.5f;

        _yRandom = Random.Range(-1.5f,2.5f);

    }
    void Update()
    {
        if (_trocou)
        {
            transform.position += new Vector3(speed, _yRandom, 0) * Time.deltaTime;
        }
        else if (!_trocou)
        {
            transform.position -= new Vector3(speed, _yRandom, 0) * Time.deltaTime;
        }


    }
}
