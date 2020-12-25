using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HealingDropController : BaseItemController
{
    public int HP { get; set; }

    public HealingDropController(int healPoints)
    {
        HP = healPoints;
    }
    public override void Interact()
    {
        //Heal player
        //...
        base.Interact();
    }
}
