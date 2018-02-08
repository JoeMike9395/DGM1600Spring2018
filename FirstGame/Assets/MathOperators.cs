using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour
{

    // int and float. Make sure the proper data type is used especially when dividing.
    // Incrementers are shortcuts for + and - 1. Done by ++ and -- value.
	// To format the document use Alt-Shift-F
	// Generally the algebra is done backwards.
	// = means ASSIGN and REPLACE
	// += Take current assignment and add value.
	//	C = A + B; C is now 20
	//	C += A + B; C is now 40
	//	C -= A - B; C is still 40
	//  c = B; C is 10
    
	public int Score = 0;
	public int PowerUp = 10;

    void OnTriggerEnter ()
    {
		Score += PowerUp;
		print(Score);
	}
}