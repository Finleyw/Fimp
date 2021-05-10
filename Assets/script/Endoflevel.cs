using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endoflevel : MonoBehaviour
{
    public playermove finish;
    public GameObject score;
    public GameObject Screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finish.end==true)
        {
            Instantiate(Screen,transform);
        }
    }
    
}
