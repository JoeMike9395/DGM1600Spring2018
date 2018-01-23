using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//this declares what start will do
	print("The animal has been eaten."); //Uppercase will error the code
	print("The hippo is now full.");
	print("Something sad just happened.");
	print("Were you expecting this to be a good game?");
	
	}
	// All functions need a () to work in C#
	// A class is a "box" containing functions that do "stuff"
	// Void is a function. A type of function. "Do work, give nothing back."
	// Update is called once per frame
	void OnMouseDown()
	{
		print("Mouse Click!");
	}
}
