using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Animator animator;
    public Rigidbody2D rb;

    

 
 
    
    void Awake()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        rb.velocity = new Vector2(movement.x, movement.y);
    }

      
}
