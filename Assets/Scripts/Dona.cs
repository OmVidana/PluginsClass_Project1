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
            if (transform.position.z < 5)
            {
                transform.position += new Vector3(0, 0, 0.7f) * Time.deltaTime;
            }
            //transform.Translate(Vector3.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Sirven para lo mismo 
            if (transform.position.x > -5)
            {
                transform.position += new Vector3(-0.7f, 0, 0) * Time.deltaTime;
            }
            //transform.Translate(Vector3.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Sirven para lo mismo 
            if (transform.position.z > -5)
            {
                transform.position += new Vector3(0, 0, -0.7f) * Time.deltaTime;
            }
            //transform.Translate(Vector3.forward*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 5)
            {
                transform.position += new Vector3(0.7f, 0, 0) * Time.deltaTime;
            }
        }
    }
}
