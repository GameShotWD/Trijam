using UnityEngine;

public class CoinEarn : MonoBehaviour
{
    PlayerInfo Player = null;

    private void Start()
    {
        Player = GetComponent<PlayerInfo>();
        enemy.Dead += Dead;
    }

    private void Dead()
    {
        Player.AddCoins(1+Player.GetMaxHP() - Player.GetHP() + Player.GetFirstHP() - Player.GetMaxHP());
    }

}
