using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform barrelend;
    public float firespeed;

    // Update is called once per frame
    void Update()
    {
      if(Input.GetButtonDown("Fire1"))
      {
        Rigidbody projectileInstance;
        projectileInstance= Instantiate(projectile, barrelend.position,barrelend.rotation) as Rigidbody;
        projectileInstance.AddForce(barrelend.forward*firespeed);
      }  
    }
}
