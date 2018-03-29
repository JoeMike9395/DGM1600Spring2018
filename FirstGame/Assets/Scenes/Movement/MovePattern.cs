using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject {

    public float speed = 6.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public void Move (CharacterController controller, Transform transform) {
        if (controller.isGrounded) {
            moveDirection.x = Input.GetAxis ("Horizontal");
            moveDirection.z = Input.GetAxis ("Vertical");
            moveDirection.y = 0;
            moveDirection = transform.TransformDirection (moveDirection);
            moveDirection *= speed;
            if (Input.GetButton ("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move (moveDirection * Time.deltaTime);
    }
}