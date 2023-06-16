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

    public void MainMenu(string NextSceneName) {
        SceneManager.LoadScene(NextSceneName);
    }

    public void What_Scene_Should_Go(string NextSceneName) {
        SceneManager.LoadScene(NextSceneName);
    }
}
