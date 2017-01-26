using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerHazard : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			SceneManager.LoadScene ("HND_LevelDesign_Tutorial_07");
		}

		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}
