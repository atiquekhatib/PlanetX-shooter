using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinspawn : MonoBehaviour
{
    [SerializeField]
    private GameObject Currnecy;

    private GameObject spawnedCurrency;

    [SerializeField]
    private Transform Cleft, Cright, Ccentre;

    private int randomSide;
    void Start()
    {
        StartCoroutine(SpawnCurrency());
    }

    IEnumerator SpawnCurrency()
    {
        while(true)
        {
        yield return new WaitForSeconds(Random.Range(15,20));
        randomSide = Random.Range(0,3);

        spawnedCurrency = Instantiate(Currnecy);
    
        //left side
        if(randomSide == 0)
        {
            spawnedCurrency.transform.position = Cleft.position;
        }
        //right side
        else if(randomSide == 1)
        {
            spawnedCurrency.transform.position = Cright.position;
        }
        //centre side
        else
        {
            spawnedCurrency.transform.position = Ccentre.position;
        }
        }
    }
}
