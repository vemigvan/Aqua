using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNPCStats : EntityStats
{
    //variable for npc's attitude to player
    private float agression;

    public float Agression { get { return agression; } }

    #region Agression
    public void IncreaseAgression(float value)
    {
        //...
    }
    public void DecreaseAgression(float value)
    {
        //...
    }
    #endregion
}
