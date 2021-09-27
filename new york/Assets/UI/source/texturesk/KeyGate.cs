using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
    
{
    public GameObject key;
   public Transform target;
    public float t;

    public Transform sceptor;
    public sceptormove sceptorMove;
    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player" && !key.activeSelf)
        {

            sceptorMove.sceptor();
            Destroy(gameObject);
            
          // StartCoroutine(ExecuteAfterTime());
        }
    }

}
