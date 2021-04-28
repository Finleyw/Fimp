using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    bool backwards=false;
    int changedelay=0;
    
   
    void Update()
    {
        if(changedelay>0)
        {
            changedelay--;
        }

        velocity.z=speed;
        isGrounded= Physics.CheckSphere(groundcheck.position, grounddistance,groundmask);
        deathwall= Physics.CheckSphere(groundcheck.position, walldistance,badwallmask);
        goodwall=Physics.CheckSphere(groundcheck.position, walldistance,goodwallmask);

        if(isGrounded&& velocity.y<0)
        {
            velocity.y=-2f;
        }

        if(deathwall)
        {           
            SceneManager.LoadScene("Game");
        }
        if(goodwall)
        {
            if(Input.GetButtonDown("Jump")&& isGrounded==false);
            {
                velocity.y=20f;
                float degrees=180;
                Vector3 to =new Vector3(0,degrees,0);
                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
                backwards=true;
                change();
            }
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

        if (backwards==true)
        {
            //Debug.Log(backwards);
            if(Input.GetKey("w"))
            {
                speed=speed-0.01f;
            }
            
           // speed= -speed;
            
        }

        if (backwards==false)
        {
            if(Input.GetKey("w"))
            {
                speed=speed+0.01f;
            }
        }

        
    }
    
    void change()
    {
            
        if (changedelay==0)
        {
            Debug.Log(backwards);

            speed= -speed;
            changedelay=10;

        }
        
            
    }
    
    
}
