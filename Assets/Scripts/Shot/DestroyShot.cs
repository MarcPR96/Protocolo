﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShot : MonoBehaviour 
{
    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Shot")
        {
            //Destroy (other.gameObject);
        }
    }
}
