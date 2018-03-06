using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Functions With Returns are not void. As it returns something back. They are a data type.
public class SimpleReturn : MonoBehaviour {

public int MyInt = 50 + 50;

void Start()
{
	MyInt = AddHealth();	
}

public int AddHealth()
{
	return 50 + 50;
}


}
