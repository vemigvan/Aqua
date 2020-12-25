using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItemController : MonoBehaviour, IInteractable
{
    protected Rigidbody rb;

    protected new string name;

    public string Name { get { return name; } }

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        //...
    }

    public virtual void Interact()
    {
        //Pick up an item
        //...
        Destroy(gameObject);
    }
}
