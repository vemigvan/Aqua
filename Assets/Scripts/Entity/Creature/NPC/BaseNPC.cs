﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNPC : Creature
{
    

    protected override void Start()
    {
        base.Start();
        InteractionController = new NPCInteractionController(this);
    }

}
