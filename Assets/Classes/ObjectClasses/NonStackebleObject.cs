using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class NonStackebleObject : Object
{
    public Pickup pickUp;

    public override string WhatYouCanDoWith()
    {
        return " pick up " + name;
    }
    public override void InteractWith(GameObject player)
    {
        pickUp.PickUp(player);
    }
}
