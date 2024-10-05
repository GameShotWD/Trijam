using UnityEngine;

public class CoinEarn : MonoBehaviour
{
    PlayerInfo Player = null;

    private void Start()
    {
        Player = GetComponent<PlayerInfo>();
    }

    private void Dead()
    {
        
    }

}
