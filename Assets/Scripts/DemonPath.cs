using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonPath : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 1)
        {
            transform.position += new Vector3(0, 0, -2.5f) * Time.deltaTime;
        }
        if (transform.position.z <= 1)
        {
            Destroy(gameObject);
        }
    }
}
