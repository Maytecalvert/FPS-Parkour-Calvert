using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHealth : MonoBehaviour
{
    public TextMeshProUGUI Txthealth;
    public EnemyHealth enemyhealth;
    public HealthManager healthManager;

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    public void UpdateHealthUI (string healthAmount)
    {
        Txthealth.text = healthAmount;
    }

   

}
