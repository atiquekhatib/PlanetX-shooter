using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex,randomSide;
    void Start()
    {
        StartCoroutine(SpawnMosters());
    }

    IEnumerator SpawnMosters()
    {
        while(true)
        {
        yield return new WaitForSeconds(Random.Range(1,5));
        randomIndex = Random.Range(0,monsterReference.Length);
        randomSide = Random.Range(0,2);

        spawnedMonster = Instantiate(monsterReference[randomIndex]);
    
        //left side
        if(randomSide == 0)
        {
            spawnedMonster.transform.position = leftPos.position;
            spawnedMonster.GetComponent<Enemy>().speed = Random.Range(1,3);
            spawnedMonster.GetComponent<Enemy>().sprite.flipX = false;

        }
        //right side
        else
        {
            spawnedMonster.transform.position = rightPos.position;
            spawnedMonster.GetComponent<Enemy>().speed = -Random.Range(1,3);
        }
        }
    }
}
