using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPoints : MonoBehaviour
{
    public TextMeshProUGUI scoreString;

    // Update is called once per frame
    void Update()
    {
        scoreString.text = Score.score.ToString();
    }
}
