using UnityEngine;
using UnityEngine.XR;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    private int SpeedLvl = 0;
    private int AtkLvl = 0;
    private int AtkSpeedLvl = 0;

    private int CostSpeedLvl = 0;
    private int CostAtkLvl = 0;
    private int CostAtkSpeedLvl = 0;

    PlayerInfo Player = null;


    private void Start()
    {
        Player = GetComponent<PlayerInfo>();
        Canvas = GameObject.Find("Shop");
        Canvas.SetActive(false);
    }
    public void BuyAtkSpeed()
    {
        Player.RemoveCoins(CostAtkSpeedLvl);
        CostAtkSpeedLvl += 10;
        Player.AtcSpeedUp();
    }
    public void BuyAtk()
    {
        Player.RemoveCoins(CostAtkLvl);
        CostAtkLvl += 10;
        Player.AddDamage();
    }
    public void BuySpeed()
    {
        Player.RemoveCoins(CostSpeedLvl);
        CostSpeedLvl += 10;
        Player.SpeedUp();
    }
    public void RemoveMaxHP()
    {
        Player.AddMaxCoin();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) {
            ChangeState();
        }
    }
    private void ChangeState()
    {
        if (Canvas.activeSelf == true)
        {
            Canvas.SetActive(false);
        }
        else
        {
            Canvas.SetActive(true);
        }
    }
}
