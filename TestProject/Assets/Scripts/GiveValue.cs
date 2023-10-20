using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveValue : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;

    public void Start()
    {
        string newText = StaticData.valueToKeep;
        scoreText.text = newText;
    }
}
