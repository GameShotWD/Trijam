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
    public void TakeDamage()
    {
        HP -= player.GetDamage();
        if (HP <= 0)
        {
            Dead();
        }
    }
    private void Dead()
    {
        player.AddCoins(Cost + player.GetMaxHP() - player.GetHP() + player.GetFirstHP() - player.GetMaxHP());
        Destroy(this.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ammo")
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
    }
}
