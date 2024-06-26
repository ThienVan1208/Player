using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float moveRange = 26.9f;

    private Vector3 oldPosition;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        oldPosition = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(new Vector3(-1 * Time.deltaTime * moveSpeed, 0, 0));
        if (Vector3.Distance(oldPosition, obj.transform.position) > moveRange)
        {
            obj.transform.position = oldPosition;
        }
    }
}
