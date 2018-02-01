using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour {

	public string Name;
	public int FoodCount;

	public Text myUIText;

	void OnMouseDown()
	{
		if (1+2 == 3)
		{
			print("3");
		}
		// Two Equal signs become a compare operator. A single equal sign is a operator.
		// To make an if not statement, type if ("stuff" != "Stuff")
        // The if statement must be true or false.
        // bool is a command that means true or false.
	
		if(Name == "Dog")
		{
			print("Bark!");
		}

		if(FoodCount > 0)
		{
			print("The pet has food.");
		}
		if(Name != "Frog")
		{
			print(Name + " is not a reptile. Or amused.");
		}
		if(FoodCount == 50)
		{
			print("Yes, I have 50 Food.");
		}
		if(Name == "Frog")
		{
			print(Name + " is a reptile, and very amused.");
		}
	}


}
