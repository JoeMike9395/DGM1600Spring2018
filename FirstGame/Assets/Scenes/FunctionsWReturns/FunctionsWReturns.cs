using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWReturns : MonoBehaviour {

    public int Health;

    public int AddHealth (int value) {
        print ("Health added.");
        return Health += value;
    }

    private void OnMouseDown () {
        Health = AddHealth (10);
		Players.Add(NewPlayer("Vanessa"));
    }

    public List<string> Players;

    public List<string> NewPlayers () {
        return new List<string> ();
    }

    public string NewPlayer (string name) {
        return name;
    }

}