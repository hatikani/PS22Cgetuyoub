using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemB : ItemManager
{
    public override void Activate()
    {
        FindObjectOfType<PlayeControl>().MaterialB();
    }
}
