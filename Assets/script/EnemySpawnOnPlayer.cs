using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnOnPlayer : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawn1;
    
    public Transform spawn3;
    
    void Update()
    {
        /*if()
        {
            Instantiate(enemy,spawn1.position,spawn1.rotation);
            Instantiate(enemy,spawn2.position,spawn2.rotation);
            Instantiate(enemy,spawn3.position,spawn3.rotation);
        }*/
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(enemy,spawn1.position,spawn1.rotation);
           
            Instantiate(enemy,spawn3.position,spawn3.rotation); 
        }
    }
}
