﻿using System.Collections;
using UnityEngine;

public class KeyItem : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player") 
        {
            GameVariables.keyCount += 2;
            Destroy(gameObject);
        }
    }
}
