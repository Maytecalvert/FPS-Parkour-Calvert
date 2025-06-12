using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int danger = 10;
    public HealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //usamos un tag par hacer más fácil la comparación/sintaxis
        {
            //restar precio al dinero del player
            if (healthManager.UpdateHealth(-danger))
            {
                Destroy(gameObject);
            }
        }
    }


}
