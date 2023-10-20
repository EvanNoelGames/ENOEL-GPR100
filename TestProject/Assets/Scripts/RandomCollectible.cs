using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{
    public ScoreScript score;
    bool nearPlayer;

    private void OnTriggerStay2D(Collider2D col)
    {
        RepositionCollectible();
    }

    void RepositionCollectible()
    {
        float newX = Random.Range(-5, 5);
        float newY = Random.Range(-3, 3);
        Vector2 newPos = new Vector2(newX, newY);
        transform.position = newPos;

        score.AddScore();
    }

    public int getScore()
    {
        return score.getScore();
    }
}
