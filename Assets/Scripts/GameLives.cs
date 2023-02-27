using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLives : MonoBehaviour
{
    public TextMeshProUGUI lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "LIVES: " + DonutCollitions.livesCharacter;
    }
}
