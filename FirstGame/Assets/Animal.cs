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
		myUIText.text = ("Hello, " + Name + ". It's time to eat " + FoodCount + " donuts!");
	}


}
