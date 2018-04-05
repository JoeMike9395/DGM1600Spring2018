using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInput")]
public class FloatInput : InputBase
{

	public string InputName = "Movement";

	public override float SetFloat ()
	{
		return Input.GetAxis(InputName);
	}
}
