using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnabled : MonoBehaviour
{
	public Collider collider;

	void Update ()
	{
		collider.enabled = false;

		if (Input.GetKeyDown (KeyCode.C)) {
			collider.enabled = true;
		}

		if (Input.GetKeyUp (KeyCode.C)) {
			collider.enabled = false;
		}
	}
}
