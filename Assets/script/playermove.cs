using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public CharacterController controller;
    public GameObject player;
    public float movespeed= 12f;
    public float gravity= -9.81f;
    public float jumpheight=3f;
    public Transform groundcheck;
    public Transform wallcheck;
    public float grounddistance;
    public float walldistance;
    public LayerMask groundmask;
    public LayerMask badwallmask;
    public LayerMask goodwallmask;
    public float speed=1f;

    Vector3 velocity;
    bool isGrounded;
    bool deathwall;
    bool goodwall;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        velocity.z=speed;
        isGrounded= Physics.CheckSphere(groundcheck.position, grounddistance,groundmask);
        deathwall= Physics.CheckCapsule(wallcheck.position, walldistance,badwallmask);

        if(isGrounded&& velocity.y<0)
        {
            velocity.y=-2f;
        }
        float x =Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right*x;

        controller.Move(move*movespeed*Time.deltaTime);

        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y=Mathf.Sqrt(jumpheight*-2f*gravity);
        }

        velocity.y += gravity*Time.deltaTime;

        controller.Move(velocity*Time.deltaTime);
    }
}
