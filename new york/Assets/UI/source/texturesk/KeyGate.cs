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
    public AudioSource Correct;

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player" && !key.activeSelf)
        {
            Correct.Play();
            sceptorMove.sceptor();
            Destroy(gameObject);
            
          // StartCoroutine(ExecuteAfterTime());
        }
    }

}
