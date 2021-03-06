﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onGroundCencer : MonoBehaviour
{
    public CapsuleCollider capcol;
    public float offest = 0.1f;

    private Vector3 point1;
    private Vector3 point2;
    private float radius;

    // Start is called before the first frame update
    void Awake()
    {
        radius = capcol.radius-0.05f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        point1 = transform.position + transform.up * (radius-offest);
        point2 = transform.position + transform.up * (capcol.height-offest) - transform.up * radius;


        Collider[] outputCols = Physics.OverlapCapsule(point1, point2, radius, LayerMask.GetMask("Ground"));
        if (outputCols.Length != 0)
        {
            //           foreach (var col in outputCols)
            //          {
            //              print("collision"+col.name);
            //           }
            SendMessageUpwards("IsGround");
            
        }
        else
        {
            SendMessageUpwards("IsNotGround");
          

        }
    }
}
