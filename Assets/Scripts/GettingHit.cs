using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingHit : MonoBehaviour
{
    // Start is called before the first frame update
    public float health;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void takeDmg(float dmg)
    {
        health -= dmg;
        Debug.Log(health);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
