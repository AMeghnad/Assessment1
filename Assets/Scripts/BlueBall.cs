﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : BallBehaviour
{

    public ScoreManager scoreManager;

    // Activates the script at the start of the game
    void Awake()
    {
        // Gets the ScoreManager at the start of game
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "BlueBucket")
        {
            scoreManager.score += 1; //scoreManager score = score + 1;
            Destroy(gameObject);
        }

        if (col.tag == "RedBucket")
        {
            Destroy(gameObject);
        }
    }
}
