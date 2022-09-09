using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract  class  ItemManager : MonoBehaviour
{
    bool Item;
    public abstract void Activate();
        
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);

    }
    public  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Activate();
            Destroy(gameObject);
        }
    }
}
