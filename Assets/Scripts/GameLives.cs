using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLives : MonoBehaviour
{
    public TextMeshProUGUI lives;
    public TextMeshProUGUI goal;
    // Start is called before the first frame update
    void Start()
    {
        lives.text = "LIVES: 3";
        goal.text = "GOAL";
    }

    // Update is called once per frame
    void Update()
    {
        lives.text = "LIVES:" + DonutCollitions.livesCharacter;
    }
}
