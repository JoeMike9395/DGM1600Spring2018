using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public MovePattern MovePattern;
    private CharacterController controller;

    private void Start () {
        controller = GetComponent<CharacterController> ();
    }

    void Update () {
        MovePattern.Move (controller, transform);
    }
}