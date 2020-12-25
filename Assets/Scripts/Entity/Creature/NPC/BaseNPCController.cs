using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNPCController : CreatureController
{
    private BaseNPCStats stats;

    public virtual BaseNPCStats Stats { get => stats; }

    protected override void Start()
    {
        base.Start();
        //...
    }

    protected override void Update()
    {
        base.Update();
        //...
    }

    protected override void Move()
    {
        //...
    }

    public override void Interact()
    {
        //Speak
    }
}
