using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePetStats : MonoBehaviour
{
    //variable for npc's attitude to player
    private int stamina;

    public int Stamina { get { return stamina; } }

    #region Agression
    public void IncreaseStamina(int value)
    {
        //...
    }
    public void DecreaseStamina(int value)
    {
        //...
    }
    public void RestoreStamina(int value)
    {
        //...
    }
    #endregion
}
