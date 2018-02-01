using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {

	public bool Key;
//If nothing is placed it is implied false. (Ex. public bool Key = true)
	public int Health = 100;
	public string Password = "OU812";
	void Start () {
		
		if (Key)
		{
			print("I have the Skeleton Key.");
		}
		else
		{
			print("YOU SHALL NOT PASS");
		}

		if (Health > 0)
		{
			print("I can play.");
		}
		else
		{
			print("You are dead.");
		}
		//The Else Clause is part of the same class as the "if statements". The same box.
		if(Password == "OU812")
		{
			print("You are correct");
		}
		else
		{
			print("WRONG");
		}
	}

	
}
