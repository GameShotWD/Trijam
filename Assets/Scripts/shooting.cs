using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject Shot;
    [SerializeField] private float shot_delay = 0;
    private bool delay = false;
    public bool active = false;
    [SerializeField] private float ShotPower = 0;
    private Rigidbody AmmoRB;
    IEnumerator Wait()
    {
        delay = true;
        yield return new WaitForSeconds(shot_delay);
        delay = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!delay)
        {
            if (active)
            {
                GameObject Ammo = Instantiate(Shot, transform.position + transform.forward, this.transform.rotation);
                AmmoRB = Ammo.AddComponent<Rigidbody>();
                AmmoRB.AddForce(transform.forward * ShotPower, ForceMode.Impulse);
                AmmoRB.useGravity = false;

                Destroy(Ammo, 5);
                StartCoroutine(Wait());
            }
        }
    }
}
