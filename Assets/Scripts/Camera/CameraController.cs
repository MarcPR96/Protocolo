﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public PlayerController player;

	public bool isFollowing;

	public float xOffset;
	public float yOffset;

    void Start()
    {
		player = FindObjectOfType<PlayerController> ();

		isFollowing = true;
    }

    void LateUpdate()
    {
		//if (player.facingRight) {
			if (isFollowing) {
				transform.position = new Vector3 (player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
			}
		//} else {
		//	transform.position = new Vector3(player.transform.position.x - xOffset, player.transform.position.y + yOffset, transform.position.z);
		//}
    	//}
	}
}