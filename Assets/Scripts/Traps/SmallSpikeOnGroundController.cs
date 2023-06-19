using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallSpikeOnGroundController : MonoBehaviour
{
    Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("StartSpike");
        }
    }
}
