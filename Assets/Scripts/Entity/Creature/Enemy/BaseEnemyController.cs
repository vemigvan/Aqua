using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyController : CreatureController
{
    private BaseEnemyStats stats;
    protected List<BaseItem> dropItems;

    public virtual BaseEnemyStats Stats { get => stats; }

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

    public override void Interact()
    {
        //атака персонажем
    }
}
