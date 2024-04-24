using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] bool GameStarted = false;
    [SerializeField] bool isPaused = true;
    public bool isPause
    {
        get{return isPaused;}
        set{isPaused = value;}
    }
    public bool gameStarted
    {
        get{return GameStarted;}
        set{GameStarted = value;}
    }

    [SerializeField] GameObject DeathScreen;
    [SerializeField] GameObject Points;
    [SerializeField] GameObject PauseScreen;
    [SerializeField] GameObject PauseButton;
    [SerializeField] PlayerUI pui;
    [SerializeField] Control ctr;
    [SerializeField] Rigidbody2D playerRB;
    void Start()
    {        

    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted) return;

        if(isPause) 
        {
            Time.timeScale = 0;
            PauseScreen.SetActive(true);
            PauseButton.SetActive(false);
        }

        if(!isPause)
        {
            Time.timeScale = 1;
            PauseScreen.SetActive(false);
            PauseButton.SetActive(true);
        }

        if(pui.isDead) 
        {
            ctr.enabled = false;
            DeathScreen.SetActive(true);
            Points.SetActive(false);
        }

        if(!pui.isDead)
        {
            ctr.enabled = true;
            DeathScreen.SetActive(false);
            Points.SetActive(true);
        }
    }
    
    
}
