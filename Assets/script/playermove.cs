using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playermove : MonoBehaviour
{
    
    public bool end;
    public Text speedcounter;
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
    public bool touchingfinish;
    public float speed=1f;
    public string scene;
    Vector3 velocity;
    
    bool isGrounded;
    bool deathwall;
    bool goodwall;
    bool backwards=false;
    int changedelay=0;
    public bool playing=true;
    int Shortdelay=1;
    private float nextActionTime = 0.0f;
    public float period = 0.001f;

    void Start()
    {
       
    }
    void Update()
    {
        //Debug.Log("backwards= " + backwards);

        Shortdelay++;
        if(Shortdelay>1)
        {
            Shortdelay=1;
            end=false;
        }
        if (touchingfinish==true)
        {
            end=true;
            playing=false;
            Shortdelay=0;
        }

        if(playing==true)
        {
            //print("change del=" + changedelay);
            speedcounter.text=speed.ToString();
            if(changedelay>0)
            {
                changedelay--;
            }

            isGrounded= Physics.CheckSphere(groundcheck.position, grounddistance,groundmask);
            deathwall= Physics.CheckSphere(groundcheck.position, walldistance,badwallmask);
            goodwall=Physics.CheckSphere(groundcheck.position, walldistance,goodwallmask);

            if(isGrounded&& (velocity.y<0) )
            {
                velocity.y=-2f;
            }

            if(deathwall)
            {           
                SceneManager.LoadScene(scene);
            }

            
            if(goodwall)
            {
                
                if( changedelay==0 )
                {
                    velocity.y=20f;
                    float degrees=180;
                    Vector3 to =new Vector3(0,degrees,0);
                    transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
                   
                    change();

                }
            }
            

            float x =Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right*x;

            controller.Move(move*movespeed*Time.deltaTime);

       

            if( (Input.GetButtonDown("Jump")) && isGrounded)
            {
            
                velocity.y=Mathf.Sqrt(jumpheight*-2f*gravity);

            }

            velocity.y += gravity*Time.deltaTime;

            controller.Move(velocity*Time.deltaTime);

            Running();
            
            
            

            //print("backw=" + backwards);

            


            /*
            if( backwards == true )
            {
                velocity.z=-speed;
            }
            else
            {
                velocity.z=speed;
            }
            */

        }
        if(Input.GetKey("r"))
        {
            SceneManager.LoadScene(scene);
        }
        
    }
    void Running()
    {
        if (Time.time > nextActionTime ) 
        {
            nextActionTime= Time.time + period;
            if(Input.GetKey("w"))
            {
                if (speed<140f)
                {
                    speed=speed+0.025f;
                }
            }   
        }  
        velocity.z = backwards?-speed:speed;

    }
    
    void change()
    {
            
        if (changedelay==0)
        {
            //Debug.Log(backwards);

            backwards = !backwards;
            changedelay=5;
        }
        
        
        
            
    }
    
    
    
    
}
