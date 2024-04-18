using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed = 1.0f;
    public float speedUp = 1.0f;
    public Animator anim;
    public GameObject go;
    public float inputing = 0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            go.SetActive(true);
            if(transform.position.y < 5) rb.AddForce(Vector2.up * speedUp);
        }
        else go.SetActive(false);
        //Player Control
        if (Input.GetMouseButtonDown(0))
        {
            inputing = -1f;
            rb.velocity = Vector2.left * speed;
            transform.rotation = Quaternion.Euler(0, 0, -inputing * 40);
        }
        if (Input.GetMouseButtonDown(1))
        {
            inputing = 1f;
            rb.velocity = Vector2.right * speed;
            transform.rotation = Quaternion.Euler(0, 0, -inputing * 30);
        }
        
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            inputing = 0;
            transform.rotation = Quaternion.Euler(0, 0, -inputing * 30);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BG"))
        {
            anim.SetBool("isGround", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BG"))
        {
            anim.SetBool("isGround", false);
        }
    }

       
    
}
