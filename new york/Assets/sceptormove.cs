﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceptormove : MonoBehaviour
{
    public Transform target;
    public float t;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    public void sceptor()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.Lerp(a, b, t);
    }
}
