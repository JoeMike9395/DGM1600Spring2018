using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolInput : InputBase {

    public string InputName = "Jump";
    public float FloatValue = 1;

    public override float SetFloat () {
        if (Input.GetButton (InputName)) {
            return FloatValue;
        }
		else
		{
			return 0;
		}
    }
}