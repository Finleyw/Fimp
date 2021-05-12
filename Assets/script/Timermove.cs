using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timermove : MonoBehaviour
{
    public playermove finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finish.end==true)
        {
            LeanTween.moveY(gameObject,0f,0f);
        }
    }
}
