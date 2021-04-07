using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    bool facingLeft;
    public int techo;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (techo==1)
        {

            gameObject.transform.rotation = Quaternion.Euler(180, 0, 0);
        }
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && !collision.collider.CompareTag("Player") && collision.collider.CompareTag("Ground"))
        {
            facingLeft = !facingLeft;
        }



        if (facingLeft)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
       
    }
}
