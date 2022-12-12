using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    [SerializeField]
     private float Jumpforce = 10f;
    public float h;
    private bool isGrounded = true;
    private Animator anim;
    private string Walk_Animation = "walk";
    private string Jump_Animation = "fly";
    private string Enemy_Tag = "Enemy";
    public bool isDead = false;
    public Deathhandler trydeath;
    private string Ground_Tag = "Ground";
    public Rigidbody2D myBody;

    void Awake()
    {
        anim = GetComponent<Animator>();
        myBody = GetComponent<Rigidbody2D>();
        trydeath = FindObjectOfType<Deathhandler>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        Playermove();
        Animateplayer();
    }

    void FixedUpdate()
    {
        playerJump();
    }

    void Playermove()
    {
        //movement
        h = Input.GetAxisRaw("Horizontal");
        Vector2 pos = transform.position;
        pos.x += h * speed * Time.deltaTime;
        transform.position = pos;
    }

    void Animateplayer()
    {
        if(h > 0)
        {
        anim.SetBool(Walk_Animation,true);
        transform.rotation = Quaternion.Euler(0,0,0); //rotation
        }

        else if(h < 0)
        {
        anim.SetBool(Walk_Animation,true);
        transform.rotation = Quaternion.Euler(0,-180,0);
        }

        else
        {
        anim.SetBool(Walk_Animation,false);
        }
    }

    void playerJump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            isGrounded = false;
            anim.SetBool(Walk_Animation,false);
            myBody.AddForce(new Vector2(0f,Jumpforce),ForceMode2D.Impulse);
            anim.SetBool(Jump_Animation,true);

        }

    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        if(collsion.gameObject.CompareTag(Ground_Tag))
        {
            anim.SetBool(Jump_Animation,false);
            isGrounded = true;
        }

        if(collsion.gameObject.CompareTag(Enemy_Tag))
        {
            isDead = true;
            trydeath.Death();
            Destroy(gameObject);
        }
    }

}
