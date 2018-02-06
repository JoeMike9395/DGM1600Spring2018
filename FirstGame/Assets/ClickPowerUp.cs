using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUp : MonoBehaviour {

	public PowerUp MyPowerUp;

		void OnMouseDown()
		{
			if (MyPowerUp.Name == "Health")
			{
				print("I have the POWER!!!");
			}

		}

}
