using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyStats : EntityStats
{
    protected int baseDamage;
    protected int currentDamage;

    public int CurrentDamage { get { return currentDamage; } }

    #region Damage
    public void AddDamage(int value)
    {
        //...
    }
    public void SubDamage(int value)
    {
        //...
    }
    public void RestoreDamage()
    {
        currentDamage = baseDamage;
    }
    #endregion
}
