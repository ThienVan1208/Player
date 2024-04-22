using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalPointCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmp;
    public PlayerUI pui;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = "Your Points: " + pui.point.ToString();
    }
}
