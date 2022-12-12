using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawn : MonoBehaviour
{
  [SerializeField]
    private GameObject Power;

    private GameObject spawnedPower;

    [SerializeField]
    private Transform Lpower, LCpower, Cpower, RCpower, Rpower;

    private int randomSide;
    
    void Start()
    {
        StartCoroutine(SpawnPower());
    }

    IEnumerator SpawnPower()
    {
        while(true)
        {
        yield return new WaitForSeconds(Random.Range(15,30));
        randomSide = Random.Range(0,3);

        spawnedPower = Instantiate(Power);
    
        //left side
        if(randomSide == 0)
        {
            spawnedPower.transform.position = Lpower.position;
        }
        //left centrer side
        else if(randomSide == 1)
        {
            spawnedPower.transform.position = LCpower.position;
        }
        //right side
        else if(randomSide == 2)
        {
            spawnedPower.transform.position = Rpower.position;
        }
        //right centre side
        else if(randomSide == 3)
        {
            spawnedPower.transform.position = RCpower.position;
        }
        //centre side
        else
        {
            spawnedPower.transform.position = Cpower.position;
        }

        }
    }
}
