/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPush : MonoBehaviour
{
	public Transform enemyPos;

	public bool toPush;

	[Header ("Player")]
	public PlayerController playerController;
	public Rigidbody playerRB;


	void Start () 
	{
		playerController = GetComponent<PlayerController> ();
		playerRB = GetComponent<Rigidbody> ();

		toPush = false;
	}

	void FixedUpdate () 
	{
		if ((toPush = true) && (Input.GetKeyDown (KeyCode.C))){
			
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			toPush = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") {
			toPush = false;
		}
	}
}*/
