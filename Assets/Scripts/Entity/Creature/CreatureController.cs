using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CreatureController : EntityController, IInteractable
{
    //some fields and props

    public abstract void Interact();
}
