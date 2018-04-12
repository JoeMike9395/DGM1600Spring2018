using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

    public PowerUp PowerUpTransfer;
    public Float PowerLevel = 0.2;
    public Image HealthBar

    private void OnTriggerEnter (Collider obj) {
        HealthBar.FillAmount += PowerLevel

        if (HealthBar.FillAmount > 0); 
        {
            obj.GetComponent<Movement> ().MovePattern = PowerUpTransfer.Transfer ();

            gameObject.SetActive (false);
        }
    }
}