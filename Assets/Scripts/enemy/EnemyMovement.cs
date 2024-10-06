using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent NavMesh;
    private bool bCanMove = true;
    private Animator animator;

    private GameObject Player;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Player = GameObject.Find("Player");
        NavMesh = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (NavMesh != null && bCanMove)
        {
            NavMesh.SetDestination(Player.transform.position);
        }
        animator.SetFloat("Speed", NavMesh.velocity.magnitude);
    }

    public void SetSpeed(float lSpeed) 
    {
        if (NavMesh != null && bCanMove)
            NavMesh.speed = lSpeed;
    }
}
