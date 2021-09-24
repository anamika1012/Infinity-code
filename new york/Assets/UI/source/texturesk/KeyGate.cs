using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
    
{
    public GameObject key;
    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player" && !key.activeSelf)
        {
          
           
            Destroy(gameObject);
            gameObject.AddComponent<Rigidbody>();
        }
    }
}
