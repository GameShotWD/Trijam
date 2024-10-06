using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerAttak : MonoBehaviour
{
    PlayerInfo playerInfo;
    Animator animator;

    private void Start()
    {
        playerInfo = GetComponent<PlayerInfo>();
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
