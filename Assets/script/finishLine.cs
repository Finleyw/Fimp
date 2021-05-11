using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finishLine : MonoBehaviour
{
    public float timeStart=60;
    public Text textbox;
    public playermove finish;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text=timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart+=Time.deltaTime;
        textbox.text=timeStart.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("hello");

            finish.touchingfinish=true;
            

        }
    }
    

}
