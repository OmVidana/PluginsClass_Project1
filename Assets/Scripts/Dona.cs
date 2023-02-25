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
            //Sirven para lo mismo 
            if (transform.position.z < 15)
            {
                transform.position += new Vector3(0, 0, 3f) * Time.deltaTime;
            }
            //transform.Translate(Vector3.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-2f, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Sirven para lo mismo 
            if (transform.position.z > 1.4)
            {
                transform.position += new Vector3(0, 0, -3f) * Time.deltaTime;
            }
            //transform.Translate(Vector3.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(2f, 0, 0) * Time.deltaTime;
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
