using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coincollect : MonoBehaviour
{
   public bool coincollected = false;

    void Update()
    {
        if(coincollected == false)
        {
            Invoke("destroyPower",10f);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
        coincollected = true;
        Destroy(gameObject);
        }
    }

    void destroyPower()
    {
        Destroy(gameObject);
    }
}
