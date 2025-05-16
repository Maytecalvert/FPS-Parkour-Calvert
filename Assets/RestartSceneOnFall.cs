using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnFall : MonoBehaviour
{
    public float deathFallHeight = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathFallHeight)
        {
            Debug.Log("Respawn");
            SceneManager.LoadScene("FPS Parkour");
        }
    }
}
