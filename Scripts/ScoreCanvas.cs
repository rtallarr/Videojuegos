using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCanvas : MonoBehaviour
{
    public float score;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
