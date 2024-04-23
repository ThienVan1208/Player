using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThienThachNgangDoc : MonoBehaviour
{
    private Vector3 pos;
    private bool goRight = false;
    public float speed = 1f;
    public float distance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (goRight)
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            if (transform.position.x >= pos.x + distance)
            {
                goRight = false;
            }
        }
        else
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
            if (transform.position.x <= pos.x - distance)
            {
                goRight = true;
            }
        }
    }
}
