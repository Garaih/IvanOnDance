using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject[] effects = new GameObject[4];

    public AudioSource music;

    public bool startPlaying;

    public Scroller scr;

    public int currentScore;
    public int minScorePerNote;
    public int maxScorePerNote;
    public int scorePerNote;
    public int multiplier;
    public int multiplierTracker;
    public int multiplierThreshold;

    public int maxMisses;
    int misses;

    public Text scoreText;
    public Text multText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentScore = 0;
        multiplier = 1;
        multiplierTracker = 0;
        misses = 0;
        scoreText.text = "Score: " + currentScore;
        multText.text = "Multiplier: x" + multiplier;
    }
    
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                scr.start = true;

                music.Play();
            }
        }
    }

    public void NoteHit(float value, Vector2 pos)
    {
        multiplierTracker++;

        if (multiplierTracker % multiplierThreshold == 0)
        {
            multiplier++;
            multiplierTracker = 0;
        }

        float maxScoreAdd = maxScorePerNote - minScorePerNote;
        float minDistance = 0.1f;
        float maxDistance = 1f;

        float scoreToAdd = minDistance + (maxScoreAdd - minDistance) * ((value - maxDistance) / (0 - maxDistance));

        scoreToAdd = Mathf.Clamp(scoreToAdd, 0, maxScoreAdd);

        if (value <= 0.1f)
        {
            scoreToAdd = 50;
        }

        if ((minScorePerNote + (int)scoreToAdd) == 150)
        {
            Instantiate(effects[3], pos, effects[3].transform.rotation);
        }

        else if ((minScorePerNote + (int)scoreToAdd) < 125)
        {
            Instantiate(effects[1], pos, effects[1].transform.rotation);
        }

        else if ((minScorePerNote + (int)scoreToAdd) < 150)
        {
            Instantiate(effects[2], pos, effects[2].transform.rotation);
        }

        currentScore += (minScorePerNote + (int)scoreToAdd) * multiplier;

        scoreText.text = "Score: " + currentScore;
        multText.text = "Multiplier: x" + multiplier;
    }

    public void NoteMiss(Vector2 pos)
    {
        Instantiate(effects[0], pos, effects[0].transform.rotation);

        multiplier = 1;
        multiplierTracker = 0;

        multText.text = "Multiplier: x" + multiplier;

        misses++;

        if (misses > maxMisses)
        {

        }
    }
}
