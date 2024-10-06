using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    CapsuleCollider Collider;
    private bool delay = false;
    [SerializeField] private int Damage = 10;
    [SerializeField] private int AttackDelay = 1;

    private void Start()
    {
        Collider = GetComponent<CapsuleCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInfo Player = other.gameObject.GetComponent<PlayerInfo>();
        if (Player && !delay)
        {
            Player.TakeDamage(Damage);
            Wait();
        }
    }
    IEnumerator Wait()
    {
        delay = true;
        yield return new WaitForSeconds(AttackDelay);
        delay = false;
    }
}
