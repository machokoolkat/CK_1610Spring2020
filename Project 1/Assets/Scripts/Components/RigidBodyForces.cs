﻿using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyForces : MonoBehaviour
{
   private Rigidbody rigidBodyObj;
   public float force = 300;
   private Vector3 forceVector;

   private void Start()
   {
      rigidBodyObj = GetComponent<Rigidbody>();
   }

   private void OnCollisionEnter(Collision other)
   {
      forceVector.y = force;
      rigidBodyObj.AddForce(forceVector);
   }
}
