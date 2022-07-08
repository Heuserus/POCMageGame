using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Spell : ScriptableObject
{

    public Sprite icon;

    public float dmg;
    public float manaCost;
    public bool continuos;

    public virtual void Cast(GameObject player, GameObject crosshair)
    {
        Debug.Log("This Spells has no Cast yet");
    }
    
   
}
