﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Player Player;
    private CharacterController controller;

    private void Start () {
        controller = GetComponent<CharacterController> ();
    }

    void Update () {
        Player.MovePattern.Move (controller, transform);
    }
}