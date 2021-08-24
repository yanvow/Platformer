using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI[] scoreText;
    public TextMeshProUGUI[] highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSeconds;

    public bool scoreIncreasing;

    public Restarter resarter;

    // Use this for initialization
    void Start () {

        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }

    }

    // Update is called once per frame
    void Update() {

        if(Time.timeScale == 0f || resarter.deathMenuUI.activeSelf)
        {
            scoreIncreasing = false;
        }
        else if(Time.timeScale == 1f)
        {
            scoreIncreasing = true;
        }

        if (scoreIncreasing)
        {
            scoreCount += pointsPerSeconds + Time.deltaTime;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }

        //scoreText.text = "SCORE: " + Mathf.Round(scoreCount);
        //highScoreText.text = "HIGH SCORE: " + Mathf.Round (highScoreCount);

        for (int i = 0; i < scoreText.Length; i++)
        {
            scoreText[i].text = "SCORE: " + Mathf.Round(scoreCount); 
        }

        for (int i = 0; i < highScoreText.Length; i++)
        {
            highScoreText[i].text = "HIGH SCORE: " + Mathf.Round(highScoreCount);
        }
    }
}
