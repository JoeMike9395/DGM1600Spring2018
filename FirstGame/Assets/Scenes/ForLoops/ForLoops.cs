using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {
    //A For Loop is a shortcut that shortens code. Instead of having to:
    //print Name 1; Spam

    public string[] Keys;
    //The brackets make it an array.

    // Use this for initialization
    void Start () {
        for (int i = 0; i < Keys.Length; i++)
        //ForLoops start with a Declaration, an If Statement, The Loop (If true), and the work done (If true). Repeat until false.
        //The Declaration (int i = 0) only runs once.
		//.Length is the Array size, or number.
        //The .Length gets the int required to make the statement true.
        //Because Names is a string, not an int.
        {
            if (Keys[i] == "Skull") {
                print (Keys[i]);
				print (i);
            }
        }
        //ForEach loops are better, and shorter.
        //But sometimes you'll need to use For Loops.

    }

    void Run()
    {
        for (int i = 0; i < Keys.Length; i++)
        {
            print (Keys);
        }
    }
    // Run is a function we can make and use whenever we want.

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Run();
        }
    }
}