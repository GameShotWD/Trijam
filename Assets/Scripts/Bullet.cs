using UnityEngine;

public class Bullet : MonoBehaviour
{
    enemy Enemy;
    private int Damage = 0;
    PlayerInfo Player;

    private void Start()
    {
        Player = GameObject.Find("Player").GetComponent<PlayerInfo>();
        SetDamage(Player.GetDamage());
    }
    public void SetDamage(int damage)
    {
        Damage = damage;
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if(Enemy = other.gameObject.GetComponent<enemy>())
            Enemy.TakeDamage(Damage);
        Debug.Log(Enemy);
        Destroy(gameObject);
    }
}
