using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public string UserName;

    void Start () {
        switch (UserName) 
        {
            case "Password":
                print ("Password is correct");
                break; //This ends the case search so it doesn't search everything.

            case "LevelUp":
                print ("You win! Next level.");
                break;

            case "BlackPanther":
                print("Made over 200 million this weekend!");
                break;

            default: //If neither of the above are true, it skips and goes to default.
                //else is reserved for if statements. So default is used instead.
                print ("Why don't you just tell me which movie you want to see?");
                break;

        }

    }

}