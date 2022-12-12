using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollected : MonoBehaviour
{
    Coincount count;
    public bool powercollected = false;
    //public int Currency = 0;

    void Start() 
    {
        count = FindObjectOfType<Coincount>();    
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Power")
        {
        powercollected = true;
        //Destroy(gameObject);
        }

        if(other.gameObject.tag == "Currency")
        {
            count.Dispcount();
            //Currency = Currency+1;
            //Debug.Log(Currency);
        }
    }

    
}
