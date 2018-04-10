using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	private MovePattern prevMovePattern

	private void OnTriggerEnter(Collider obj)
	{
		MovePattern prevMovePattern = obj.GetComponent<Movement>().MovePattern;

		obj.GetComponent<Movement>().MovePattern = PowerUpTransfer.Transfer();

	

		gameObject.SetActive(false);
	}

	void RestoreMovePattern (MovePattern oldMovePattern)
	{

	}
	
}
