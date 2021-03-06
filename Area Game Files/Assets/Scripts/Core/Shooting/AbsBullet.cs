﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsBullet : MonoBehaviour
{
    [SerializeField]
    protected float muzzleVel; //velocity in m/s (1 unit = 1 meter)
    [SerializeField]
    protected int damage;
    public LayerMask mask;


    protected RaycastHit hit;
    protected Vector3 angle;
    protected Transform position;
    

    public virtual void Awake()
    {

    }

    public virtual void Update()
    {
        
    }

    protected virtual void checkForward()
    {
        if(Physics.Raycast(position.position, angle, out hit, muzzleVel*Time.deltaTime, mask))
        {
            //Event system goes here
        }
    }

}
