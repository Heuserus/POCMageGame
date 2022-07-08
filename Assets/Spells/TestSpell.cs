using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TestSpell : Spell
{
    public string test;
    public override void Cast()
    {
        Debug.Log("TestSpell");
    }

}
