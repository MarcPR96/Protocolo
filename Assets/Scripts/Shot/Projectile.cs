using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour 
{
	public float speed;

	public PlayerController player;
	public Rigidbody rb;


	// Use this for initialization
	void Start () 
	{
		player = FindObjectOfType<PlayerController> ();
		rb = FindObjectOfType<Rigidbody> ();

		if (!player.facingRight)
			speed = -speed;

	}
	
	// Update is called once per frame
	void Update ()
	{
		rb.velocity = new Vector3 (speed, rb.velocity.y, 0);
	}

	void OnTriggerEnter (Collider other)
	{
        if (other.tag != "Shot")
        {
            Destroy(gameObject);
        }

        if (other.tag == "PushItem" || other.tag == "Enemy")
        {
            
        }
	}
}
