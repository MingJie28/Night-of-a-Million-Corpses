using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] Image icon;
    public WhipWeapon weapon;

    public void Set(UpgradeData upgradeData) 
    {
        icon.sprite = upgradeData.icon;
    }

    internal void Clean()
    {
        icon.sprite = null;
    }



    public void upgradeWeapon(UpgradeData upgradeData)
    {
        string x = upgradeData.upgradeType.ToString();
        if (x == "WeaponUpgrade")
        {
            weapon.weaponStats.damage += 15;
        }
    }
}
