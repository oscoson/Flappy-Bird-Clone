using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreString;
    public static int score = 0;
    public static int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score > highScore)
        {
            highScore = score;
        }
        scoreString.text = score.ToString();
    }
}
