using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : EntityStats
{
    private int maxMP;
    private int currentMP;
    private int currentXP;
    private int currentLVL;
    private int money;


    public int CurrentMP{ get { return currentMP;  } }
    protected override void Start()
    {
        base.Start();
        //...
    }

    #region Mana
    public void AddMP(int value)
    {
        //...
    }
    public void SubMP(int value)
    {
        //...
    }
    public void RestoreMP()
    {
        currentMP = maxMP;
    }
    #endregion

    #region Experience
    public void AddXP(int value)
    {
        //...
        //if (blablabla) IncreaseLevel();
    }
    public void ResetXP()
    {
        currentXP = 0;
    }
    private void IncreaseLevel(int value = 1)
    {
        currentLVL += value;
        //...
    }
    #endregion

    #region Money
    public void AddMoney(int value)
    {
        //...
    }
    public void SubMoney(int value)
    {
        //...
    }
    #endregion

    public override void Restore()
    {
        base.Restore();
        RestoreMP();
    }
}
