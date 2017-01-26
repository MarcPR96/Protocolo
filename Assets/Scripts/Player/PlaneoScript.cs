using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneoScript : MonoBehaviour
{
	private PlayerController thePlayer;

	void Start () 
	{
		thePlayer = FindObjectOfType<PlayerController> ();
	}
	
	void Update () 
	{
		
	}
}
