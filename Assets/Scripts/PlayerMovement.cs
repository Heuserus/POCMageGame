using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 moveDelta;
    public Animator animator;

    

    public GameObject fireBall;
    public GameObject crosshair;

    public Vector3 distance = new Vector3((float)0.3, (float)0.3, 0);
 
    
    void Awake()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal",x);

        

        // Reset MoveDelta
        moveDelta = new Vector3(x, y, 0);

        if (moveDelta.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0,0);
        transform.position = transform.position + horizontal * Time.deltaTime;

        Vector3 vertical = new Vector3(0, Input.GetAxis("Vertical"), 0);
        transform.position = transform.position + vertical * Time.deltaTime;
    }
}
