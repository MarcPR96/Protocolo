using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerCombat : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			SceneManager.LoadScene ("HND_LevelDesign_CombatArena");
		}

		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
	}
}
