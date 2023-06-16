using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject Player = GameObject.FindGameObjectWithTag("Player");

            Debug.Log("You have completed the level.");
            // Display the Win UI
            // UI must contain next level and the main menu btn
            Player.GetComponent<PlayerController>().enabled = false; // Disable Player Movement

        }
    }

    
}
