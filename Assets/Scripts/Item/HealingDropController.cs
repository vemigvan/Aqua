using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class HealingDropController //: BaseItem
{
    public int HP { get; set; }

    public HealingDropController(int healPoints)
    {
        HP = healPoints;
    }
    
}
