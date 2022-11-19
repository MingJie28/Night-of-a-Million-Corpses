using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float maxHp;
    public float currentHp;

    public int armor = 0;

    public StatusBar hpBar;

    [HideInInspector] public Level level;
    [HideInInspector] public Coins coins;
    private bool isDead;

    private void Awake()
    {
        level = GetComponent<Level>();
        coins = GetComponent<Coins>();
    }

    private void Start()
    {
        hpBar.SetState(currentHp, maxHp);
        Debug.Log(currentHp + " " + maxHp);
    }

    public void TakeDamage(int damage) 
    {
        if (isDead == true) { return; }
        //ApplyArmor(ref damage);

        currentHp -= damage;

        if (currentHp <= 0) 
        {
            GetComponent<CharacterGameOver>().GameOver();
            isDead = true;
            Timer.timerStop = true;
        }
        hpBar.SetState(currentHp, maxHp);
    }

    private void ApplyArmor(ref int damage)
    {
        damage -= armor;
        if (damage < 0) { damage = 0; }
    }

    public void Heal(int amount) 
    {
        if (currentHp <= 0) { return; }

        currentHp += amount;
        if (currentHp > maxHp) 
        {
            currentHp = maxHp;
        }
        hpBar.SetState(currentHp, maxHp);
    }
}
