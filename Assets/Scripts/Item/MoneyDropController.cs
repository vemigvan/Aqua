using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MoneyDropController : BaseItemController
{
    public int Amount { get; set; }

    public MoneyDropController(int moneyAmount)
    {
        Amount = moneyAmount;
        name = moneyAmount.ToString();
    }

    public override void Interact()
    {
        //Recieve money
        //...
        base.Interact();
    }
}
