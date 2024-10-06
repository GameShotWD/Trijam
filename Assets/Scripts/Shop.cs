using UnityEngine;
using UnityEngine.XR;

public class Shop : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    private int SpeedLvl = 0;
    private int AtkLvl = 0;
    private int AtkSpeedLvl = 0;
    private void Start()
    {
        Canvas = GameObject.Find("Shop");
        Canvas.SetActive(false);
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
