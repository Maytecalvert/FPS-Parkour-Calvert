using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIHealth uiHealth;

    // Start is called before the first frame update
    void Start()
    {
        uiHealth.UpdateHealthUI(playerHealth.ToString());
    }

    public bool UpdateHealth(float amount)
    {

        if (playerHealth + amount < 0)
        {
            //impedir compra
            return false;
        }
        else
        {
            playerHealth += amount;
            uiHealth.UpdateHealthUI(playerHealth.ToString());
            return true;
        }
    }
}
