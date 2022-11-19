using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBar : MonoBehaviour
{
    [SerializeField] Transform bar;
    private float currentHP;
    private float currentArmor;

    public void Update()
    {
        bar.transform.localScale = new Vector3(currentHP, 0.05f,1f);
        Debug.Log(currentHP);

        bar.transform.localScale = new Vector3(currentArmor, 0.05f, 1f);
    }

    public void SetState(float current, float max) 
    {
        this.currentHP = current/max;
        this.currentArmor = current / max;
    }
}
