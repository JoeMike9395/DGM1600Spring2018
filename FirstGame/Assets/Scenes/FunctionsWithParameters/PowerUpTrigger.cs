using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

//We need MonoBehavior as OnTriggerEnter is inside of it.

	public PowerUp MyPowerUp;
	public Player MyPlayer;


	private void OnTriggerEnter()
	{
		AddPower(MyPowerUp);
	}

	void AddPower (PowerUp powerUp)
	{
		//Do work.
		print(powerUp.PowerLevel);
		MyPlayer.Health += MyPowerUp.PowerLevel;
	}

}

// Simpler code here, but more work down the road.
//	public int PowerLevel;

//	private void OnTriggerExit()
//{
//	print(PowerLevel);
//}