using TMPro;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private int HP = 0;
    [SerializeField] private int FirstHP = 10;
    [SerializeField] private int MaxHP = 0;
    [SerializeField] private int Coins = 0;
    [SerializeField] private int MaxCoins = 0;
    [SerializeField] private int Damage = 0;
    [SerializeField] private TMP_Text CoinsText;
    [SerializeField] private TMP_Text HPText;

    private Shooting shot;
    private PlayerMovement PM;

    private void Start()
    {
        shot = GetComponent<Shooting>();
        PM = GetComponent<PlayerMovement>();
        MaxHP = FirstHP;
        HP = MaxHP;
        Coins = 0;
    }
    private void Update()
    {
        CoinsText.text = "Coins: " + Coins.ToString();
        HPText.text = "HP: " + HP.ToString();
    }
    
    public void AtcSpeedUp()
    {
        shot.SetAtkSpeed(1);
    }
    public void SpeedUp() {
        PM.Speed += 1;
    }
    public void AddMaxCoin()
    {
        if (MaxHP > 1) {
            SetMaxHP(MaxHP - 1);
            MaxCoins += 10;
        }
    }

    public int GetDamage()
    {
        return Damage;
    }
    public void AddDamage()
    {
        Damage++;
    }
    public void TakeDamage(int Damage)
    {
       if (HP - Damage <= 0) 
        {
            HP = 0;
            Dead();
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
    public bool RemoveCoins(int NewCoins)
    {
        if (Coins - NewCoins >= 0)
        {
            Coins -= NewCoins;
            return true;
        }
        return false;
    }
    public void SetMaxCoins(int NewMaxCoins)
    {
        MaxCoins = NewMaxCoins;
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
        Time.timeScale = 0;
    }
}


