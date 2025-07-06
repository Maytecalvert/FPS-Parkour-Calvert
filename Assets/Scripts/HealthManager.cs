using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UIHealth uiHealth;

    void Start()
    {
        uiHealth.UpdateHealthUI(playerHealth.ToString());
    }

    public bool UpdateHealth(float amount)
    {
        
        if (playerHealth + amount < 0)
        {
            //no cambia nada
            return false;
        }
        else
        {
            playerHealth += amount;
            uiHealth.UpdateHealthUI(playerHealth.ToString());

            // Si la vida llega a 0, se reinicia el personaje a la posición inicial
            if (playerHealth <= 0)
            {
                SceneManager.LoadScene("FPS Parkour");
            }

            return true;
        }
    }
}

