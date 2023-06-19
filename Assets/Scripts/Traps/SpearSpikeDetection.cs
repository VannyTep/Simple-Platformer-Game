using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSpikeDetection : MonoBehaviour
{
    public static bool IsAttack = false;

    Animator animator;
    GameObject Parent;

    private void Start() {
        Parent = GameObject.Find("SpearSpikeTrap"); 
        animator = Parent.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            IsAttack = true;
            animator.SetTrigger("StartSpike");
        }
    }
}
