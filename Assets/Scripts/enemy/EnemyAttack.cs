using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    CapsuleCollider Collider;
    [SerializeField] private int Damage = 10;

    private void Start()
    {
        Collider = GetComponent<CapsuleCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInfo Player = other.gameObject.GetComponent<PlayerInfo>();
        if (Player)
            Player.TakeDamage(Damage);
    }
}
