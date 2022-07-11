using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{


    public Spell spell1;
    public Spell spell2;

    public KeyCode key;
    public KeyCode key2;

    public GameObject crossHair;
    
    
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            spell1.Cast(gameObject,crossHair);
            
        }
        if (Input.GetKeyDown(key2))
        {
            spell2.Cast(gameObject,crossHair);
        }
    }
}
