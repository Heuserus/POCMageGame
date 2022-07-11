using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour

    
{

    public float dmg;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject);
        col.gameObject.transform.parent.gameObject.GetComponent<GettingHit>().takeDmg(dmg);
        Destroy(gameObject);



    }
}
