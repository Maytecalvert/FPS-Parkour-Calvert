using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public DineroManager dineroManager;
    public Mercancias mercancias;
    public TextMeshProUGUI Txtprecio;

    // Start is called before the first frame update
    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dineroManager  && Txtprecio )
        {
            Txtprecio.text = "$" + dineroManager.playerMoney.ToString("F2");
        }
        else
        {
            Debug.Log("hubo un error");
        }
    }
}
