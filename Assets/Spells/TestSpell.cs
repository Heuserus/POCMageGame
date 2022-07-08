using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spells/TestSpell")]
public class TestSpell : Spell
{
    
    public override void Cast(GameObject player, GameObject crosshair)
    {
        Debug.Log("TestSpell");
    }

}
