using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHighScore : MonoBehaviour
{
    public TextMeshProUGUI scoreString;

    // Update is called once per frame
    void Update()
    {
        scoreString.text = Score.highScore.ToString();
    }
}
