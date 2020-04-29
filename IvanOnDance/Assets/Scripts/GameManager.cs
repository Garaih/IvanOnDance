using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public AudioSource music;

    public bool startPlaying;

    public Scroller scr;

    public int currentScore;
    public int scorePerNote;
    public int multiplier;
    public int multiplierTracker;
    public int multiplierThreshold;

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

    public void NoteHit()
    {
        print("hola");

        multiplierTracker++;

        if (multiplierTracker % multiplierThreshold == 0)
        {
            multiplier++;
            multiplierTracker = 0;
        }

        currentScore += scorePerNote * multiplier;

        scoreText.text = "Score: " + currentScore;
        multText.text = "Multiplier: x" + multiplier;
    }

    public void NoteMiss()
    {
        print("adios");

        multiplier = 1;
        multiplierTracker = 0;

        multText.text = "Multiplier: x" + multiplier;
    }
}
