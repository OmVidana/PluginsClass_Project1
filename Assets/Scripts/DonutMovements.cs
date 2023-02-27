using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Juego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.z < 16.9)
            {
                transform.position += new Vector3(0, 0, 2.5f) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -1.6)
            {
                transform.position += new Vector3(-3f, 0, 0) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.z > 1.4)
            {
                transform.position += new Vector3(0, 0, -3f) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 1.6)
            {
                transform.position += new Vector3(3f, 0, 0) * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.position.y < 5)
            {
                transform.position += new Vector3(0, 5f, 0) * Time.deltaTime;
            }
        }
        else
        {
            if (transform.position.z > 1.4)
            {
                transform.position += new Vector3(0, 0, -1.5f) * Time.deltaTime;
            }
        }
    }
}
