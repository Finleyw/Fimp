using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ememy : MonoBehaviour
{
    
    public float speed;
    public float despawntime;
    private Transform target;

    public bool hungry;
    
    void Start()
    {
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
            despawntime--;
        }
        if (despawntime==0)
        {
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
            transform.localScale = new Vector3(10,10,10);
        }
        else if(target.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-10,10,10);
        }
        
        if(target.position.z>transform.position.z)
        {
            transform.localScale = new Vector3(10,10,10);
        }
        else if (target.position.z<transform.position.z)
        {
            transform.localScale=new Vector3(10,10,-10);
        }
    }
}