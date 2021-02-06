﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   public Transform target;

   public Vector3 offset;

   void Start(){
       offset = target.position - transform.position;
   }
    
    
    void Update () {
        transform.position = target.position - offset;
        transform.LookAt(target);
    }
}
