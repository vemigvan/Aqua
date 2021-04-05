using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : Creature
{
    protected override void Start()
    {
        base.Start();
        InteractionController = new EnemyInteractionController(this);
    }
}
