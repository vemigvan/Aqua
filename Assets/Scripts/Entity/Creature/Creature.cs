using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : Entity, IInteractable
{
    [SerializeField] private float _interactionDistance;
    [SerializeField] private float _stoppingDistance;

    public InteractionController InteractionController { get; protected set; }
    public float InteractionDistance => _interactionDistance;
    public float StoppingDistance => _stoppingDistance;
    public Transform Body => transform;

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _interactionDistance);
    }
}
