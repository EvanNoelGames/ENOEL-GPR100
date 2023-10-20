using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchStart : MonoBehaviour
{

    public void SwitchScene()
    {
        SceneManager.LoadScene("Game");
    }
}