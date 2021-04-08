using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulMovement : MonoBehaviour
{
    public int giro;
    public int speed;
    private Rigidbody2D rb2d;
    private bool start;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            if (speed > 0)
            {

                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            else if (speed < 0)
            {

                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);

            }
            if (giro == 1)
            {
                gameObject.transform.rotation = Quaternion.Euler(180, 0, 0);
                if (speed > 0)
                {

                    gameObject.transform.rotation = Quaternion.Euler(180, 0, 0);

                }
                else if (speed < 0)
                {

                    gameObject.transform.rotation = Quaternion.Euler(180, 180, 0);

                }
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            Destroy(this.gameObject);

        }
        if (collision.gameObject.CompareTag("paretg"))
        {
            speed = -speed;

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            start = true;
        }

    }

}
