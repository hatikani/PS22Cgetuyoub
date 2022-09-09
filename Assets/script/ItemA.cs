using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemA : ItemManager
{
   
    public override void Activate()
    {
        FindObjectOfType<PlayeControl>().MaterialA();
    }
}
