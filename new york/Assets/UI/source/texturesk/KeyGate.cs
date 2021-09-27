using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
    
{
    public GameObject key;
   public Transform target;
    public float t;

    public Transform sceptor;

    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.name == "Player" && !key.activeSelf)
        {
          
           
            Destroy(gameObject);
            gameObject.AddComponent<Rigidbody>();
            Invoke("sceptormovement", 1.0f);
          // StartCoroutine(ExecuteAfterTime());
        }
    }

 void  sceptormovement()
    {
        
        Vector3 a = sceptor.position;
        Vector3 b = target.position;
        sceptor.position = Vector3.Lerp(a, b, t);
        Debug.Log("called");



    }
}
