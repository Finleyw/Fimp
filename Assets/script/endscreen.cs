using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Game");
    }
    public void Next()
    {
        SceneManager.LoadScene("Lv2");
    }
}
