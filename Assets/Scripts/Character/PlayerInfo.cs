using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private int HP = 0;
    [SerializeField] private int FirstHP = 10;
    [SerializeField] private int MaxHP = 0;
    [SerializeField] private int Coins = 0;
    [SerializeField] private int MaxCoins = 0;
    [SerializeField] private int Damage = 0;

    public int GetDamage()
    {
        return Damage;
    }
    public void TakeDamage(int Damage)
    {
       if (HP - Damage <= 0) 
        {
            HP = 0;
        }
        else
        {
            HP -= Damage;
        }
    }
    public int GetFirstHP()
    {
        return FirstHP;
    }
    public int GetHP()
    {
        return HP;
    }
    public int GetMaxHP()
    {
        return MaxHP;
    }
    public void SetMaxHP(int hp)
    {
        MaxHP = hp;
        HP = MaxHP;
    }
    public void AddCoins(int NewCoins)
    {
        if (Coins + NewCoins <= MaxCoins)
        {
            Coins += NewCoins;
        }
        else Coins = MaxCoins;
    }
    public void SetMaxCoins(int NewMaxCoins)
    {
        MaxCoins = NewMaxCoins;
    }

    private void Start()
    {
        MaxHP = FirstHP;
        HP = MaxHP;
        Coins = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ammo")
        {
            if (HP > 0)
            {
                HP -= 1;
            }
            if (HP == 0)
            {
                Dead();
            }
        }
    }

    void Dead()
    {

    }
}


