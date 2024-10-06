using UnityEngine;
using System;

public class enemy : MonoBehaviour
{
    [SerializeField] private int HP = 0;
    private PlayerInfo player;
    [SerializeField] private int Cost =0;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerInfo>();
    }
    public void TakeDamage(int Damage)
    {
        Debug.Log("Damage");
        if (HP - Damage <= 0)
        {
            HP = 0;
            Dead();
        }
        else
            HP -= Damage;
    }
    private void Dead()
    {
        player.AddCoins(Cost - player.GetHP() + player.GetFirstHP());
        Destroy(this.gameObject);
    }
   /* private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ammo")
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
    }*/
}
