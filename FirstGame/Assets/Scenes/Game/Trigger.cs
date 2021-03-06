﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

    public PowerUp PowerUpTransfer;
    public float PowerLevel = 1.0F;
    public Image HealthBar;
    public Color Healthy;
    public Color Low;
    public Color Critical;
    public enum Collect
    {
        SpeedBoost, AntiGrav, Explosion
    }
    public Collect PlayerPower;
    public float AddHealth(){

        return HealthBar.fillAmount += PowerLevel;
    }

    private void OnTriggerEnter (Collider obj) {

        obj.GetComponent<Movement>().Player.MovePattern = PowerUpTransfer.Transfer ();
        if (HealthBar.fillAmount > 0); 
        {
            PowerLevel = AddHealth();
        }

        gameObject.SetActive (false);
    }

    private void Update()
    {
        if (HealthBar.fillAmount >= 0.5F)
        {
            HealthBar.color = Color.green;
        }
        else
        {
            HealthBar.color = Color.red;
        }

        switch(PlayerPower)
        {
            case Collect.SpeedBoost:
                print("You're a very fast boi.");
                break;

            case Collect.AntiGrav:
                print("You feel funny.");
                break;

            case Collect.Explosion:
                print("Exaplossssion.");
                break;
           
        }

        while (HealthBar.fillAmount <= 0.1F)
        {
            print("Holy @#$# you need health!");
        }
    }
}