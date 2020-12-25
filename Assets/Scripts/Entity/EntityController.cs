using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityController : MonoBehaviour
{
    protected Rigidbody rb;
    protected Animator anim;
    protected Vector3 startPoint;

    protected LayerMask groundLayer;

    protected new string name;

    public string Name { get { return name; } }

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        //...
    }

    protected virtual void Update()
    {
        //...
    }

    protected virtual void Move()
    {
        //...
    }

}
