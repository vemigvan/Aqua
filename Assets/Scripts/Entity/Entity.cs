using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody), typeof(Collider), typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
public abstract class Entity : MonoBehaviour
{
    public ServiceManager ServiceManager { get; private set; }
    public Rigidbody RB { get; private set; }
    public Collider Collider { get; private set; }
    public Animator Animator { get; private set; }
    public NavMeshAgent NavMeshAgent{ get; private set; }
    protected Vector3 StartPoint { get; private set; }
    protected LayerMask groundLayer;
    public EntityActionController ActionController { get; protected set; }

    protected new string name;
    public string Name { get { return name; } }

    protected virtual void Start()
    {
        ServiceManager = ServiceManager.Instance;
        RB = GetComponent<Rigidbody>();
        Collider = GetComponent<Collider>();
        Animator = GetComponent<Animator>();
        NavMeshAgent = GetComponent<NavMeshAgent>();

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
