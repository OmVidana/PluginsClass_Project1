using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DonutCollitions : MonoBehaviour
{
    public static int livesCharacter;
    public static int points;
    void Start()
    {
        livesCharacter = 3;
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Demon(Clone)")
        {
            Destroy(other.gameObject);
            livesCharacter--;
            points++;
            if(livesCharacter < 1)
            {
                SceneManager.LoadScene("lose");
            }
        }
        if (other.gameObject.name == "Star(Clone)")
        {
            Destroy(other.gameObject);
            if (livesCharacter < 3)
            {
                livesCharacter++;
            }
        }
        if (other.gameObject.name == "FloorEnd")
        {
            SceneManager.LoadScene("win");
        }
    }
}
