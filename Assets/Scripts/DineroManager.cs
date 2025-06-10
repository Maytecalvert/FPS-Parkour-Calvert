using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
    public UIManager uiManager;

    void Start()
    {
        uiManager.UpdateMoneyUI(playerMoney.ToString());
    }

    public bool UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            //impedir compra
            return false;
        }
        else
        {
            playerMoney += amount;
            uiManager.UpdateMoneyUI(playerMoney.ToString());
            return true;
        }
    }

}
