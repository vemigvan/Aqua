using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePetController : CreatureController
{
    private BasePetStats stats;

    public virtual BasePetStats Stats { get => stats; }

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
        //pet a pet. hehe
    }
}
