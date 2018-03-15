using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject {

    protected float aNum;
    protected float bNum;
	//protected is seen by the children of the code.
	//private is only for this script and this script only.


    public string Calculate (string a, string b) {
		aNum = float.Parse(a);
		bNum = float.Parse(b);

        return FinishCalculation();
		}

		public abstract string FinishCalculation();


}