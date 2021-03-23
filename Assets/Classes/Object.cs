using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Object : ScriptableObject
{     
    public string name;    

    public string GetName() { return name; }

    public virtual string WhatYouCanDoWith()
    {
        return name;
    }

    public virtual void InteractWith(GameObject player)
    {

    }
}
