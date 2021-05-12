using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endoflevel : MonoBehaviour
{
    public playermove finish;
    
    public GameObject Screen;
    bool spawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn==false)
        {
            if (finish.end==true)
            {
                 
                Instantiate(Screen,transform);
                spawn=true;
            }
        }
    }
    
}
