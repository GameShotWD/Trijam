using UnityEngine;
using System;

public class enemy : MonoBehaviour
{
    public static Action Dead;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ammo")
        {
            if (Dead != null) Dead.Invoke();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
