using System.Collections;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    [SerializeField] private float shot_delay = 0;
    private bool delay = false;
    public bool active = false;
    [SerializeField] private float ShotPower = 5;
    private Rigidbody AmmoRB;
    [SerializeField] private Animator animator;

    public void SetAtkSpeed(int AtkSpeed) {
        shot_delay -= 0.1f; 
    }
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
                animator.SetTrigger("Attack");
                
                GameObject Ammo = Instantiate(Bullet, transform.position + transform.forward + new Vector3(0, 1, 0), this.transform.rotation);
                AmmoRB = Ammo.AddComponent<Rigidbody>();
                AmmoRB.AddForce(transform.forward * ShotPower, ForceMode.Impulse);
                AmmoRB.useGravity = false;

                Destroy(Ammo, 5);
                StartCoroutine(Wait());
            }
        }
    }
}
