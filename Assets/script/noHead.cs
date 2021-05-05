using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noHead : MonoBehaviour
{
    private Animator anim;
    public Ememy script;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
        //GameObject g = GameObject.FindGameObjectWithTag (Bad);
        //script=g.GetComponent<Ememy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(script.hungry==false)
        {
            anim.SetBool("Fed",true);
            Debug.Log("yep");
        }
    }
}
