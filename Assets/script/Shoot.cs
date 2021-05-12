using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  private Animator anim;
  public Rigidbody projectile;
  public Transform barrelend;
  public float firespeed;
  public playermove finish;
  int delay = 0;

  void Start()
  {
    anim= GetComponent<Animator>();
  }

    // Update is called once per frame
  void Update()
  {
    
      if (delay>0)
      {
        delay--;
      }
      if(Input.GetButtonDown("Fire1"))
      {
        
        
        fire();
        
        
        
      } 
      if (delay==0)
      {
        anim.SetBool("Fire",false);
      } 
    
      
        

  }
  void fire()
  {
    if(delay==0)
    {
      Rigidbody projectileInstance;
      projectileInstance= Instantiate(projectile, barrelend.position,barrelend.rotation) as Rigidbody;
      projectileInstance.AddForce(barrelend.forward*firespeed);
      anim.SetBool("Fire",true);
      delay=21;
    }
  }

}
