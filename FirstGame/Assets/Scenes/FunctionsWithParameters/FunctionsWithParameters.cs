using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour {

	public int Health = 20;

	void OnTriggerEnter(Collider other)
	//(DATATYPE IDENTIFIER)
	//Collider is a class and part of MonoBehavior.
	//Collision contacts and stops. Trigger contacts and passes through.
	{
		print("Hit something!");
		print(other);

		AddNumbers(14, 2);
		PlayerData("Bob");
		//The Call

		AddHealth(25);
	}

		void AddHealth(int newHealth)
		{
			Health += newHealth;
		}

	//The Declaration
	void AddNumbers(int a, int b)
	//a is a variable. It can be anything. We called it and made it 14.
	{
		print(a += b);
	}

	void PlayerData(string name)
	{
		print("This player is " + name);
	}
}
