using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coincount : MonoBehaviour
{
    //ItemCollected count;
    //TMP_Text countText;
    public Text coinCount;
    public int collect = 0;

    /*void Awake() 
    {
        coinCount = GetComponent<ItemCollected>();    
    }*/
    void Start()
    {
     //count = GetComponent<Coincollect>();
     //countText = GetComponent<TMP_Text>();
     coinCount.text = collect.ToString();
    }
    
    public void Dispcount()
    {
        collect +=1 ;
        coinCount.text = collect.ToString();

        //countText.text = count.ToString();
    }
}
