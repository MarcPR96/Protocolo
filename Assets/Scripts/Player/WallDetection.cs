using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetection : MonoBehaviour 
{
	public bool isTouchingWall;

	void Start()
	{
		isTouchingWall = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ground" || other.tag == "PushItem") {
			isTouchingWall = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Ground" || other.tag == "PushItem") {
			isTouchingWall = false;
		}
	}
}
