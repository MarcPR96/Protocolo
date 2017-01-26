using UnityEngine;
using System.Collections;

public class StatesEnemy: MonoBehaviour 
{
	public enum States	{IDLE, HUNT, ATTACK, DAMAGE, DEAD}
	public States state;	//Declaramos una variable del tipo States 

	[Header("Transforms")]
	public Transform target; //target = player.
	public Animator enemyAnim;

	[Header("Distances")]
	public float distanceFromTarget ;
	public float huntRange;
	public float attackRange;

    public float speedEnemy;


	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update ()
	{
		switch (state) 	//Esta estructura usa cada funcion independientemente un estado de otro
		{
		case States.IDLE:
			{
				UpdateIdle ();
				break;
			}
		case States.HUNT:
			{
				UpdateHunt ();
				break;
			}
		case States.ATTACK:
			{ 
				UpdateAttack ();
				break;
			}
		/*case States.DAMAGE:
			{
				UpdateDamage ();
				break;
			}
		case States.DEAD:
			{
				UpdateDead ();
				break;
			}*/
		default:
			break;
		}
	}

	void UpdateIdle()
	{
		distanceFromTarget = Vector3.Distance (transform.position, target.position);

		if(distanceFromTarget <= huntRange)
		{
            //transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speedEnemy * Time.deltaTime);

            SetHunt();
			enemyAnim.SetBool("isHunt",true);
			enemyAnim.SetBool ("Attack", false);
		}
	}

	void UpdateHunt()
	{
		distanceFromTarget = Vector3.Distance (transform.position, target.position);

		if(distanceFromTarget >= huntRange)
		{
			enemyAnim.SetBool ("isHunt", false);
			enemyAnim.SetBool ("Attack", false);
			SetIdle ();
		}

		if(distanceFromTarget <= attackRange)
		{
			enemyAnim.SetBool ("isHunt", true);
			enemyAnim.SetBool ("Attack", true);
			SetAttack();
		}

	}

	void UpdateAttack()
	{
		SetIdle ();
	}

	void UpdateDamage()
	{

	}

	void UpdateDead()
	{

	}

	void SetIdle()
	{
		state = States.IDLE;
	}

	void SetHunt()
	{
		state = States.HUNT;
	}

	void SetAttack()
	{
		state = States.ATTACK;
	}

	/*void SetDamage()
	{
		state = States.DAMAGE;
	}

	void SetDead()
	{
		state = States.DEAD;
	}*/

}
