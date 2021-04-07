using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity;
    public float speed;
    private GameObject player;
    private Rigidbody2D rb2d;
    private Animator m_Animator;
   
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown("w") && (rb2d.velocity.y == 0.0f))
        {
            gravity = gravity * -1;
            m_Animator.SetInteger("Correr", 1);
            
           

          
            
            

        }
        if (gravity < 0)
        {
            transform.eulerAngles = new Vector3(180, 0, 0);
        }
        else { transform.eulerAngles = new Vector3(0, 0, 0); }
        
        

        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        rb2d.gravityScale = gravity;
    }
    
}
