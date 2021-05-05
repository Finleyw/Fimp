using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ememy : MonoBehaviour
{
    public GameObject hearts;
    public float speed;
    public float despawntime=120f;
    private Transform target;

    public bool hungry;
    public bool heartSpawned;
    void Start()
    {
        heartSpawned=false;
        hungry=true;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {   
        if(hungry==true)
        {
            move();
        }
        if(hungry==false)
        {
            if(heartSpawned==false)
            {
                heartSpawned=true;
                Instantiate (hearts);
            }
            
            despawntime--;
        }
        if (despawntime==0)
        {
            Destroy(hearts);
            Destroy(gameObject);
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            hungry=false;
        }
    }

    void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if(target.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if(target.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        
        if(target.position.z>transform.position.z)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if (target.position.z<transform.position.z)
        {
            transform.localScale=new Vector3(1,1,-1);
        }
    }
}