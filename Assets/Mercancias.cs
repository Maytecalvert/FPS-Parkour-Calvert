using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercancias : MonoBehaviour
{
    public int scorePoints;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }
}
