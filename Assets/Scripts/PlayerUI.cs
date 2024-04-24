using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Control control;
    [SerializeField] int Point = 0;
    [SerializeField] bool IsDead = false;
    
    public int point
    {
        get{return Point;}
        set{Point = value;}
    }
    public bool isDead
    {
        get{return IsDead;}
        set{IsDead = value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        control = GetComponent<Control>();
        rb = GetComponent<Rigidbody2D>();
        rb.Sleep();
    }

    // Update is called once per frame
    void Update()
    {
        if(control.enabled) rb.WakeUp();
    }
}

