using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    private int _score = 0;

    public void AddScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }

    public int getScore()
    {
        return _score;
    }
}
