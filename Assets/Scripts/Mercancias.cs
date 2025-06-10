using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercancias : MonoBehaviour
{
    public int precio =10;
    public DineroManager dineroManager;
    
    void Start ()
    {

        dineroManager = FindObjectOfType <DineroManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //usamos un tag par hacer más fácil la comparación/sintaxis
        {
            //restar precio al dinero del player
            if (dineroManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }
        }
    }
}
