using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

    public float speed = 6.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public InputBase InputX;
    public InputBase InputZ;
    public InputBase InputY;

    public void Move (CharacterController controller, Transform transform) {
        if (controller.isGrounded) {
            //This is a boolean variable. (On/Off)
            //Place a ! before controller to make it move when not grounded.
            moveDirection.x = InputX.SetFloat();
            moveDirection.z = InputZ.SetFloat();
            moveDirection.y = InputY.SetFloat();
            moveDirection = transform.TransformDirection (moveDirection);
            moveDirection *= speed;
            if (Input.GetButton ("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move (moveDirection * Time.deltaTime);
    }
}