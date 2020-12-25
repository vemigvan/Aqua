using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : MonoBehaviour
{
    //Movement
    protected float baseHorSpeed;
    protected float currentHorSpeed;
    protected float basejumpForce;
    protected float currentJumpForce;

    //HealthSystem
    protected int maxHP;
    protected int currentHP;
    protected float invincibilityTime;

    #region Properties
    public virtual float CurrentHorSpeed { get { return currentHorSpeed; } }
    public virtual float CurrentHP { get { return currentHP; } }
    public virtual float CurrentHumpForce { get { return currentJumpForce; } }

    #endregion

    protected virtual void Start()
    {
        Restore();
        //...
    }

    #region Health
    public virtual void AddHP(int value)
    {
        //...
    }
    public virtual void SubHP(int value)
    {
        //...
    }
    public virtual void RestoreHP()
    {
        currentHP = maxHP;
    }
    #endregion

    #region Speed
    public virtual void AddSpeed(int value)
    {
        //...
    }

    public virtual void SubSpeed(int value)
    {
        //...
    }

    public virtual void RestoreSpeed()
    {
        currentHorSpeed = baseHorSpeed;
    }
    #endregion

    #region Jump
    public virtual void AddJumpForce(int value)
    {
        //...
    }
    public virtual void SubJumpForce(int value)
    {
        //...
    }
    public virtual void RestoreJumpForce()
    {
        currentHP = maxHP;
    }
    #endregion


    public virtual void Restore()
    {
        RestoreHP();
        RestoreJumpForce();
        RestoreSpeed();
    }

}
