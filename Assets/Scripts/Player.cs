using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    void HandleMovement() {
        if(isLocalPlayer) {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horizontal * 0.1f, vertical * 0.1f);
            transform.position += movement;
        }
    }

    void Update() {
        HandleMovement();
    }
}
