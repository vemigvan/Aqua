using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class BaseItem : MonoBehaviour, IInteractable
{
    public Rigidbody RB { get; private set; }
    public Collider Collider { get; private set; }

    [SerializeField] private float _interactionDistance;
    [SerializeField] private float _stoppingDistance;

    public InteractionController InteractionController { get; protected set; }
    public float InteractionDistance => _interactionDistance;
    public float StoppingDistance => _stoppingDistance;
    public Transform Body => transform;

    protected virtual void Start()
    {
        RB = GetComponent<Rigidbody>();
        Collider = GetComponent<Collider>();
        InteractionController = new ItemInteractionController(this);
        //...
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _interactionDistance);
    }
}
