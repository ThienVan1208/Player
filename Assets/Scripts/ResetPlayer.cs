using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    Button PlayAgainButton;
    public GameObject player;
    void Start()
    {
        PlayAgainButton = GetComponent<Button>();
        PlayAgainButton.onClick.AddListener(onClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick()
    {
        Transform transform = player.GetComponent<Transform>();
        transform.position = new Vector2(-3.42f, 3.01f);
    }

}
