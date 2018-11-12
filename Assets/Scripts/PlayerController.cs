using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool doubleJump;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate() {

        var hitColliders = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, whatIsGround);
        this.grounded = (hitColliders.Length > 0) ? true : false;
    }


    void Update () {


       // if (Input.GetKey(KeyCode.Space)) {
        if (Input.GetKeyDown(KeyCode.Space) && this.grounded) {
                //Jump();
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpHeight, 0);
                doubleJump = true;

        }

        if ((Input.GetKeyDown(KeyCode.Space)) && doubleJump && !grounded) {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpHeight, 0);
            doubleJump = false;
        }



        if (Input.GetKey(KeyCode.D)) {
            //MoveForward();
            GetComponent<Rigidbody>().velocity = new Vector3(moveSpeed, GetComponent<Rigidbody>().velocity.y, 0);
        }
        if (Input.GetKey(KeyCode.A)) {
            // MoveBackwards();
            GetComponent<Rigidbody>().velocity = new Vector3(-moveSpeed, GetComponent<Rigidbody>().velocity.y, 0);
        }

    }
}
