using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushItemcontrol : MonoBehaviour
{
    PlayerController player;

    public Transform pushItmePos;
    public Collider col;

    Rigidbody pushItemRB;

    public bool moveItem;

    public int forceDisplace;

    void Start()
    {
        pushItemRB = GetComponent<Rigidbody>();

        player = GetComponent<PlayerController>();

        moveItem = true;
    }

    void Update()
    {
        if (moveItem && Input.GetKeyDown(KeyCode.C))
        {
            if (player.facingRight)
            {
                pushItemRB.AddForce(new Vector3(forceDisplace, 0, 0));
            }
            else
            {
                pushItemRB.AddForce(new Vector3(-forceDisplace, 0, 0));
            }
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            moveItem = true;
            Debug.Log("You can move something");
        }
    }
}
