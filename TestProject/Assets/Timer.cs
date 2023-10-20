using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft = 10;
    public TMPro.TextMeshProUGUI timerText;
    public bool isTimerRunning = false;

    public SceneSwitch switcher;
    public GetScore scoreSaver;

    private void Start()
    {
        // Starts the timer automatically
        isTimerRunning = true;
    }
    void Update()
    {
        if (isTimerRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0;
                isTimerRunning = false;
                scoreSaver.loadEndSceneKeepScore();
                switcher.SwitchScene();
            }
        }
        timerText.text = ((int)timeLeft).ToString();
    }
}
