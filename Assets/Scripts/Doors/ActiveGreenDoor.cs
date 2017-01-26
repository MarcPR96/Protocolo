using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveGreenDoor : MonoBehaviour
{
	public PlayerController player;

	public Animator animHandle;
	public Animator openDoor;

	public void Update ()
    {
		RotateHandle ();
		OpenDoor ();
	}

	public void RotateHandle()
	{

		if (player.inHandleGreen && Input.GetKeyDown (KeyCode.F)) {
			animHandle.SetBool ("isOpenGreen", true);
			openDoor.SetBool ("openGreenDoor", true);
		}
	}

	public void OpenDoor()
	{

	}
}
