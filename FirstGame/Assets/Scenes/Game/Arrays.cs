using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

public string[] Starts;

	void Start ()
    {
        print (Starts[2]);
    }

void Run()
    {
        for (int i = 0; i < Starts.Length; i++)
        {
            print (Starts[i]);
        }
    }
}