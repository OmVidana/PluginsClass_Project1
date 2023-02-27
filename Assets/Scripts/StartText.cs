using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class StartText : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI start;
    // Start is called before the first frame update
    void Start()
    {
        title.text = "Escaping from Hell";
        start.text = "Press Enter to Start";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("game");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
