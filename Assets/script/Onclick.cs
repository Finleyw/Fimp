using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Onclick : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
    public AudioManager sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
    
        print("selected");
        sound.Play("click");
    }
}
