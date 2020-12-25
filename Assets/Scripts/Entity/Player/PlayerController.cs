using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerController : EntityController
{
    private PlayerStats stats;

    public PlayerStats Stats { get => stats;}

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

    private void Attack()
    {

    }
}
