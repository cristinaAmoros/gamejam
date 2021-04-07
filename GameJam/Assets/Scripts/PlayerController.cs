using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float gravity;
    public float speed;
    private GameObject player;
    private Rigidbody2D rb2d;
    private Animator m_Animator;
    float timer;
    Boolean gir;
   
    

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

        if (Input.GetKeyDown("space") && (rb2d.velocity.y == 0.0f))
        {
            gravity = gravity * -1;
            m_Animator.SetInteger("Correr", 1);
            gir = true;
        }
        if (gravity < 0)
        {
            transform.eulerAngles = new Vector3(180, 0, 0);
        }
        else { transform.eulerAngles = new Vector3(0, 0, 0); }
        
        if(gir == true)
        {
            timer += Time.deltaTime;
            _ = timer >= 0.1f;
        }

        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        rb2d.gravityScale = gravity;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("mort"))
            {
            SceneManager.LoadScene("mort");
        }
    }

}
