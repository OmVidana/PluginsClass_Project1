using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoseText : MonoBehaviour
{
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Lives Used: " + DonutCollitions.points;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("game");
        }
    }
}
