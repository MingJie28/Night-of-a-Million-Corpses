using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBar : MonoBehaviour
{
    [SerializeField] Transform bar;
    private float currentHP;

    public void Update()
    {
        bar.transform.localScale = new Vector3(currentHP, 0.05f,1f);
        Debug.Log(currentHP);
    }

    public void SetState(float current, float max) 
    {
        this.currentHP = current/max;
    }
}
