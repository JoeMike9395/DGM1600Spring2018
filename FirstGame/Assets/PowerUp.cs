using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Method is an alternate word for function.
//This script is not part of MonoBehavior.
//print is part of MONOBEHAVIOR. So use Debug.Log () Instead.

[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	public int PowerLevel = 10;
	public Player CurrentPlayer;

	public void RunPowerUp()
	{
		CurrentPlayer.Score += PowerLevel;
		//This finds the script.
	}


}
