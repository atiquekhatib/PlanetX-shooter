using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCollect : MonoBehaviour
{
   // public GameObject powerupdemo;
   public bool powercollected = false;

    void Update()
    {
        if(powercollected == false)
        {
            Invoke("destroyPower",3f);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
        powercollected = true;
        Destroy(gameObject);
        }
    }

    void destroyPower()
    {
        Destroy(gameObject);
    }
}
