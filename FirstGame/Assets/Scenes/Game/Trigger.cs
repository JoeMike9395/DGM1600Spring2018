using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

    public PowerUp PowerUpTransfer;
    public float PowerLevel = 1.0F;
    public Image HealthBar;

    public float AddHealth(){

        return HealthBar.fillAmount += PowerLevel;
    }

    private void OnTriggerEnter (Collider obj) {

        obj.GetComponent<Movement> ().MovePattern = PowerUpTransfer.Transfer ();
        if (HealthBar.fillAmount > 0); 
        {
            PowerLevel = AddHealth();
        }

        gameObject.SetActive (false);
    }

    public void ColorChange(){
        if (PowerLevel < 0.5F);
        {
            HealthBar.color = Color.green;
        }
    }

}