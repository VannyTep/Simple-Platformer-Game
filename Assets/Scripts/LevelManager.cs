using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject WinUIMenu;
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject Player = GameObject.FindGameObjectWithTag("Player");

            WinUIMenu.SetActive(true); // Display the Win UI
            Player.GetComponent<PlayerController>().enabled = false; // Disable Player Movement

            Debug.Log("You have completed the level.");  
        }
    }

    
}
