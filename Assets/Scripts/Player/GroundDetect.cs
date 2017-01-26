using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetect : MonoBehaviour 
{
	public bool isGrounded;

	void Start()
	{
		isGrounded = true;
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Ground") {
			isGrounded = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Ground") {
			isGrounded = false;
		}
	}
}
