using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{

    public Transform firePoint;
    public GameObject Power;
    public LineRenderer Laser;
    public int damage;
    ItemCollected collect;

    void Start()
    {
        collect = GetComponent<ItemCollected>();
    }

    // Update is called once per frame
    void Update()
    {
        Power.SetActive(false);
        if(collect.powercollected == true)
        {
        PowerCheck();
        }
    }

    void PowerCheck()
    {
        if(Input.GetButton("Fire2"))
        {
        Shoot();
        }
    }

    void Shoot()
    {
        
        Power.SetActive(true);
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position,firePoint.right);
        if(hitInfo)
        {
        EnemyHealth enemy = hitInfo.transform.GetComponent<EnemyHealth>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Laser.SetPosition(0,firePoint.position);
        Laser.SetPosition(1,hitInfo.point);
        }

        Invoke("deactivatePower",5.0f);
    }

    void deactivatePower()
    {
        Power.SetActive(false);
        collect.powercollected = false;
    }

}