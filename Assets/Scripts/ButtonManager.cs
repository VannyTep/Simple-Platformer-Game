using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        
    }

    public void Go_Next_Level(string NextSceneName) {
        SceneManager.LoadScene(NextSceneName);
    }
}
