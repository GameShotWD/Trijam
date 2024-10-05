using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 10;
    private float HorizontalInput = 0;
    private float VerticalInput = 0;

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 Direction = new Vector3(HorizontalInput, 0, VerticalInput);
        transform.Translate(Direction * Speed * Time.deltaTime);
    }
}