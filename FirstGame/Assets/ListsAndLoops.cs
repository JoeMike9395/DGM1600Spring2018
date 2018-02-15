using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListsAndLoops : MonoBehaviour 
{

	//[] means we have arrayed it
	//The public list<> is mandatory.
	public SuperHeroes SuperHeroes;
	public Text AddMember;

	public void OnMouseDown()
	{
		SuperHeroes.FamilyList.Add(AddMember.text);
	}
}
