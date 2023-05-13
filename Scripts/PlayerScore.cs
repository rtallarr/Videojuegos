using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    ScoreCanvas scoreCanvasScript;
    bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        scoreCanvasScript = GameObject.FindObjectOfType<ScoreCanvas>();
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            scoreCanvasScript.score += 1 * Time.deltaTime;
            scoreCanvasScript.UpdateScoreText();
        }
    }
}
