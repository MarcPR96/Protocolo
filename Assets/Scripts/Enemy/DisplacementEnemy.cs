using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementEnemy : MonoBehaviour
{
    PlayerController player;

	public Transform enemyPos;
	public Collider col;

	Rigidbody enemyRB;

	public bool moveEnemy;

	public int forceDisplace;

	void Start()
	{
		enemyRB = GetComponent<Rigidbody> ();

        player = GetComponent<PlayerController>();
	}

	void Update()
	{
		if (moveEnemy && Input.GetKeyDown (KeyCode.C)) 
		{
			enemyRB.AddForce (new Vector3 (forceDisplace, 0, 0));
		}

        if (player.facingRight)
        {
            enemyRB.AddForce(new Vector3(forceDisplace, 0, 0));
        }
        else
        {
            enemyRB.AddForce(new Vector3(-forceDisplace, 0, 0));
        }
			
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
		{
			moveEnemy = true;
			Debug.Log ("You can move something");
		}
	}
}
