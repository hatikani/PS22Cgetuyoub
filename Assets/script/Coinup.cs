using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinup : MonoBehaviour
{
    public CoinManager coinManager = default;
    private bool get;
    private void OnTriggerEnter(Collider other)
    {
        if (!get)
        {
            if (other.gameObject.tag == "Player")
            {
                coinManager.CoinupA();
                Destroy(gameObject);
                get = true;
            }
        }
    }
    private void Awake()
    {
        coinManager = GameObject.FindObjectOfType<CoinManager>();
    }
}

