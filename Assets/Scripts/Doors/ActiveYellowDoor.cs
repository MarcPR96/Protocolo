using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveYellowDoor : MonoBehaviour
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
		if (player.inHandleYellow && Input.GetKeyDown (KeyCode.F)) {
			animHandle.SetBool ("isOpenYellow", true);
			openDoor.SetBool ("openYellowDoor", true);
		}
	}

	public void OpenDoor()
	{
		
	}

}
