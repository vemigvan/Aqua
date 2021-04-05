using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MoneyDropController //: BaseItem
{
    public int Amount { get; set; }

    public MoneyDropController(int moneyAmount)
    {
        Amount = moneyAmount;
       //name = moneyAmount.ToString();
    }
}
