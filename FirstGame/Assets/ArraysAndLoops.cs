using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

    public Player[] Players;
    public int[] HighScores;

    void Start () {
        foreach (var player in Players)
        {
            print(player.PlayerName);
            print(player.Score);
            print(player.MPs);
        }
        //For each is the loop. Inside the parenthesis is the parameter.
        //Loops are massive time savers that shorten lines of code.

        foreach (var score in HighScores) {
            if (score >= 350) 
            {
                print(score);
            }
        }
    }
}