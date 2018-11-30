using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private float moveVelocity;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool doubleJump;


    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

    public Shoot shoot;


    void Start() {
        setMovespeed(5);
        moveVelocity = 0f;
    }

    private void FixedUpdate() {

        var hitColliders = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, whatIsGround);
        this.grounded = (hitColliders.Length > 0) ? true : false;
        GetComponent<Rigidbody>().AddForce(Physics.gravity * (GetComponent<Rigidbody>().mass * GetComponent<Rigidbody>().mass));
    }

    void Update() {
        movePlayer();
    }

    public void jumpManager() {
        if (this.grounded) {
            Jump();
            doubleJump = true;
        }
       if(doubleJump && !grounded) {
              Jump();
            doubleJump = false;
        }
        
    }

   

    public void MoveForward(bool moveForward) {
        if (moveForward)
            setMoveVelocity(moveSpeed);
        else
            setMoveVelocity(-moveSpeed);
    }


    public void movePlayer() {
        if (knockbackCount <= 0) {
            GetComponent<Rigidbody>().velocity = new Vector3(moveVelocity, GetComponent<Rigidbody>().velocity.y, 0);
            moveVelocity = 0f;
        }
        else {
            if (knockFromRight) {
                GetComponent<Rigidbody>().velocity = new Vector3(-knockback, knockback, 0);
            }
            else {
                GetComponent<Rigidbody>().velocity = new Vector3(knockback, knockback, 0);
            }
            knockbackCount -= Time.deltaTime;
        }

    }


    public void setMoveVelocity(float value) {
        this.moveVelocity = value;
    }

    public void setMovespeed(float moveSpeed) {
        this.moveSpeed = moveSpeed;
    }

    public void Jump() {
        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpHeight, 0);
    }
}
