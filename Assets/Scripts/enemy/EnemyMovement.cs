using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private float Speed = 10;
    private NavMeshAgent NavMesh;
    private bool bCanMove = true;

    [SerializeField] private GameObject Player;

    private void Start()
    {
        NavMesh = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (NavMesh != null && bCanMove)
        {
            NavMesh.SetDestination(Player.transform.position);
        }
    }
}
