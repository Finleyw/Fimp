using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishLine : MonoBehaviour
{
    bool timerRunning=true;
    public float timeStart=0;
    public Text textbox;
    public playermove finish;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text=(timeStart.ToString())+"secs";
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning==true)
        {
            timeStart+=Time.deltaTime;
            textbox.text=(timeStart.ToString())+"secs";
        }
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("pee");
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("hello");

            finish.touchingfinish=true;
            timerRunning=false;

        }
    }
    

}
