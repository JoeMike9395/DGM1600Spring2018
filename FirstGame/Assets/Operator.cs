using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour {

public int A;
public int B;
public string Password;
	
	void Start () {
		if (A == B)
		{
			print("Equal");
		}
		
		if (A > B && Password == "OU812")
		{
			print("Greater");
		}

		if (A < B && A != 10)
		{
			print("A is less than B and not equal to 10.");
		}

		if (A < B)
		{
			print("Lesser");
		}

		if (A != B)
		{
			print("Not Equal");
		}
	}
	
}
