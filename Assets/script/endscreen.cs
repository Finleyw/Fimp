using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endscreen : MonoBehaviour
{
    public playermove playermove;
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
        print("restart pressed");
    }
    public void Next()
    {
        print("next pressed");
        SceneManager.LoadScene("Lv2");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        
    }
    public void Destroy()
    {
        playermove.unpause();
        Destroy(gameObject);
    }
}
