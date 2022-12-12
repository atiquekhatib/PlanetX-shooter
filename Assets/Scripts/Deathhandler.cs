using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathhandler : MonoBehaviour
{   
    public PlayerMovement player;
    [SerializeField]
    GameObject retrybutton;
    [SerializeField]
    GameObject homebutton;
    public GameObject hero;

    void Start()
    {
        player = GetComponent<PlayerMovement>();
        retrybutton.SetActive(false);
        homebutton.SetActive(false);
    }

    public void Death()
    {
        if(player == null)
        {
            //Time.timeScale = 0;
            retrybutton.SetActive(true);
            homebutton.SetActive(true);
        }
    }
}
