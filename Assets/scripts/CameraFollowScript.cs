﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {
 public GameObject target;

    // Use this for initialisation 
    private void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);    
    }
}
