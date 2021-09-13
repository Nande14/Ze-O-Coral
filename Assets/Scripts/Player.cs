using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float saveSpeed;
    public Transform reference;
    private Vector3 vetorReferencia;
    Vector3 movement;
    private Rigidbody2D rb;
    private Animator anim;
    public LayerMask layer;
    public bool redezinha = false;
    public float radius;


    void Start()
    {
        saveSpeed = speed;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        Move();
        vetorReferencia = new Vector3(reference.position.x + 13f, 0, 0);
    }

    
    void Move()
    {
      movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
      transform.position += movement * Time.deltaTime * speed;
        if(Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);  
        }

        if (Input.GetAxis("Horizontal") < 0f)
        {
            anim.SetBool("walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        
        if (Input.GetAxis("Horizontal") == 0f)
        {
            anim.SetBool("walk", false);
        }

        if(Input.GetKey(KeyCode.Space ))
        {
            redezinha = true;
            anim.SetBool("rede", true);
        }
        if (!Input.GetKey(KeyCode.Space))
        {
            redezinha = false;
            anim.SetBool("rede", false);
        }


    }
    

}

 
