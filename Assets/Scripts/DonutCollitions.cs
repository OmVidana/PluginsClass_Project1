using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        StartCoroutine(deathTimer());
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Demon(Clone)")
        {
            Destroy(other.gameObject);
            if ((livesCharacter > 0) && (livesCharacter <= 3))
            {
                livesCharacter--;
                points++;
            }
        }
        if (other.gameObject.name == "Star(Clone)")
        {
            Destroy(other.gameObject);
            if ((livesCharacter > 0) && (livesCharacter < 3))
            {
                livesCharacter++;
            }
        }
        if (other.gameObject.name == "FloorEnd")
        {
            SceneManager.LoadScene("win");
        }
    }
    IEnumerator deathTimer()
    {
        if (DonutCollitions.livesCharacter == 0)
        {
            if (livesCharacter < 1)
            {
                yield return new WaitForSeconds(3f);
                SceneManager.LoadScene("lose");
            }
        }
    }
}
