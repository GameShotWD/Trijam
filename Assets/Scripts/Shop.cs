using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    [SerializeField]private Text SpeedLvlText;
    [SerializeField]private Text AtkLvlText;
    [SerializeField]private Text AtkSpeedLvlText;

    private int CostSpeedLvl = 0;
    private int CostAtkLvl = 0;
    private int CostAtkSpeedLvl = 0;

    PlayerInfo Player = null;


    private void Start()
    {
        Player = GameObject.Find("Player").GetComponent<PlayerInfo>();
        Canvas = GameObject.Find("Shop");
        Canvas.SetActive(false);
    }
    public void BuyAtkSpeed()
    {
        if (Player.RemoveCoins(CostAtkSpeedLvl))
        {
            Player.RemoveCoins(CostAtkSpeedLvl);
            CostAtkSpeedLvl += 10;
            Player.AtcSpeedUp();
        }
    }
    public void BuyAtk()
    {
        if (Player.RemoveCoins(CostAtkLvl))
        {
            Player.RemoveCoins(CostAtkLvl);
            CostAtkLvl += 10;
            Player.AddDamage();
        }
    }
    public void BuySpeed()
    {
        if (Player.RemoveCoins(CostSpeedLvl))
        {
            CostSpeedLvl += 10;
            Player.SpeedUp();
        }
       
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
            SpeedLvlText.text=CostSpeedLvl.ToString();
            AtkLvlText.text = CostAtkLvl.ToString();
            AtkSpeedLvlText.text = CostAtkSpeedLvl.ToString();
        }
    }
}
