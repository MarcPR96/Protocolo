using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[Header ("Movement")]
	public float speed;
	public float runSpeed;
	public float normalSpeed;
	public float fastSpeed;
	public float move;

	Rigidbody rb;
    Rigidbody2D rb2D;

	[Header ("Jumping")]
	public bool jump;
	public bool doubleJump;
	public float jumpForce;

	[Header ("Graphics and animation")]
	public bool facingRight;
	public Transform graphicsTransform;

	[Header ("GroundDetection")]
	public GroundDetect ground;

	[Header ("WallChecker")]
	public WallDetection wall;

	[Header ("Shot")]
	public Transform FirePosition;
	public GameObject Shot;

    [Header("Door")]
	public bool inHandleYellow;
	public bool inHandleGreen;
	ActiveYellowDoor activeYellowDoor;
	ActiveGreenDoor activeGreenDoor;
	//public Animator anim;

    void Start()
	{
		rb = GetComponent<Rigidbody> ();
		facingRight = true;

		ground = GetComponentInChildren<GroundDetect> ();
		wall = GetComponentInChildren<WallDetection> ();
		activeYellowDoor = GetComponent<ActiveYellowDoor> ();
		activeGreenDoor = GetComponent<ActiveGreenDoor> ();

		move = Input.GetAxis ("Horizontal");

        //inHandle = false;
		jump = true;
		doubleJump = true;
	}

	void Update()
	{
		float move = Input.GetAxis ("Horizontal");

		rb.velocity = new Vector3 (move * speed, rb.velocity.y, 0);

		if (Input.GetButton ("Fire3")) {
			rb.velocity = new Vector3 (move * runSpeed, rb.velocity.y, 0);
		}
			
		SetSpeed ();

		if (!facingRight && move > 0) Flip ();
		else if (facingRight && move < 0) Flip ();

		if (ground.isGrounded)
		{
			doubleJump = true;
			if (Input.GetButtonDown ("Jump"))
			{
				jump = true;
				rb.velocity = new Vector3 (rb.velocity.x, 0, 0);
				rb.AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
			}
		}

		if ((!ground.isGrounded) && (doubleJump)) 
		{
			if (Input.GetButtonDown ("Jump")) 
			{
				doubleJump = false;
				rb.velocity = new Vector3 (rb.velocity.x, 0, 0);
				rb.AddForce (new Vector3 (0, jumpForce, 0), ForceMode.Impulse);
                
			}
		}

		if (Input.GetKeyDown (KeyCode.C)) {
			Instantiate (Shot, FirePosition.position, FirePosition.rotation);
		}

        if(!ground.isGrounded)
        {
            Physics.gravity = new Vector3(0, -15.0f, 0);

            if (Input.GetKey(KeyCode.W))
            {
                Physics.gravity = new Vector3(0, -3f, 0);
            }
			if (Input.GetKeyUp (KeyCode.W)) 
            {
                Physics.gravity = new Vector3(0, -15.0f, 0);
            }
        }

		/*if (inHandle && Input.GetKeyDown (KeyCode.F)) {
			activeDoor.RotateHandle ();
		}*/

		/*if (inHandle && Input.GetKeyDown (KeyCode.F)) {
			activeDoor.RotateHandle ();
			activeDoor.OpenDoor ();
		}*/
	}
		
	void SetSpeed()
	{
		if (wall.isTouchingWall) {
			if (facingRight && rb.velocity.x > 0)
				speed = 0;
			else if (!facingRight && rb.velocity.x < 0)
				speed = 0;
			else if (speed == 0)
				runSpeed = 0;
		} else {
			speed = normalSpeed;
			runSpeed = fastSpeed;
		}
	}

	void Flip()
	{
		Vector3 newScale = graphicsTransform.localScale;
		newScale.x *= -1;
		graphicsTransform.localScale = newScale;

		facingRight = !facingRight;  //si vale true valdra false y viceversa
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PalancaYellow")
        {
            inHandleYellow = true;
        }

		if(other.tag == "PalancaGreen")
		{
			inHandleGreen = true;
		}
    }
}
