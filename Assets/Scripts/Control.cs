using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private bool resetCooldown = true;
    private float flyTime = 5;
    private float cooldown;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(resetCooldown);
        if (resetCooldown) cooldown = 0;
        cooldown += Time.deltaTime;
        if (cooldown <= flyTime)
        {
            if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
            {
                go.SetActive(true);
                //if(transform.position.y < 4) rb.AddForce(Vector2.up * speedUp);
            }
            else go.SetActive(false);
            //Player Control
            if (Input.GetMouseButton(1))
            {
                inputing = -1f;
                Vector3 dir = new Vector3(-0.8f, 2, 0);
                rb.velocity = dir * speed;
                transform.rotation = Quaternion.Euler(0, 0, -inputing * 40);
            }
            if (Input.GetMouseButton(0))
            {
                inputing = 1f;
                Vector3 dir = new Vector3(0.8f, 2, 0);
                rb.velocity = dir * speed;
                transform.rotation = Quaternion.Euler(0, 0, -inputing * 30);
            }

            if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
            {
                inputing = 0;
                transform.rotation = Quaternion.Euler(0, 0, -inputing * 30);
            }
        }
       
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BG"))
        {
            anim.SetBool("isGround", true);
        }
        if (collision.gameObject.CompareTag("ThienThachNgangDoc"))
        {
            gameObject.transform.SetParent(collision.gameObject.transform);
            resetCooldown = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BG"))
        {
            anim.SetBool("isGround", false);
        }
        if (collision.gameObject.CompareTag("ThienThachNgangDoc"))
        {
            gameObject.transform.SetParent(null);
            resetCooldown = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("target"))
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0;
        }
    }
}
