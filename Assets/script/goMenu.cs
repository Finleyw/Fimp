using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goMenu : MonoBehaviour
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
        SceneManager.LoadScene("Lv2");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
