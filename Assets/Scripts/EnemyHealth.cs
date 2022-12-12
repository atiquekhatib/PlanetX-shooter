using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int Health = 100;
    private Animator anim;
    public float deathtime;

    //public GameObject power;

    private int randomdrop;
    Enemy enem;
    PowerCollect item;

    public void Start()
    {
        anim = GetComponent<Animator>();
        enem = GetComponent<Enemy>();
    }
    public void TakeDamage(int damage)
    {
        Health = Health - damage;
        if(Health <= 2)
        {
            Die();
        }
    }

    void Die()
    {
       // if(isDead == false){return;}
        anim.SetBool("Die",true);
       // isDead = true;
        Invoke("afterDie",deathtime);
    }
    void afterDie()
    {
        Destroy(gameObject);
      //  powerUp();
    }

   /* void powerUp()
    {
        randomdrop = Random.Range(0,151);
        Debug.Log(randomdrop);
        
        if(randomdrop >= 20)
        {
        power = Instantiate(power,enem.transform.position,enem.transform.rotation);
        }
    }*/
}
