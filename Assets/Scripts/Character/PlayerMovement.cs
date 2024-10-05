using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.AI;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 10;
    private float HorizontalInput = 0;
    private float VerticalInput = 0;
    [SerializeField] float RotationSpeed = 10;

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
        PlayerMove();
        PlayerRotate();
    }
    void PlayerMove()
    {
        Vector3 Direction = new Vector3(HorizontalInput, 0, VerticalInput);
        transform.Translate(Direction * Speed * Time.deltaTime);
    }

    void PlayerRotate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hit, 1500);
        if (hit.collider != null)
        {
            Vector3 Direction = hit.point - transform.position;
            Direction.y = 0;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, Direction, RotationSpeed * Time.deltaTime, 0);
            transform.rotation = Quaternion.LookRotation(newDirection);

        }
    }
}