using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour
{
    public GameObject RestartCanvas;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            RestartCanvas.SetActive(true);
            GameObject Player = GameObject.FindGameObjectWithTag("Player");
            Player.SetActive(false);
        }
    }
}
