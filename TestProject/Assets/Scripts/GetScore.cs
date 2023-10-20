using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    public RandomCollectible score;

    public void loadEndSceneKeepScore()
    {
        string dataToKeep = (score.getScore()).ToString();
        StaticData.valueToKeep = dataToKeep;
    }
}
